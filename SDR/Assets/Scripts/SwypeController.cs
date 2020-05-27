using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwypeController : MonoBehaviour
{
    bool isDragging, isMobilePlatform;
    Vector2 tapPoint, swypeDelta;
    float minSwypeDelta = 130;

    public enum SwypeType
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }

    public delegate void OnSwypeInput(SwypeType type);
    public static event OnSwypeInput SwypeEvent;

    private void Awake()
    {
        #if UNITY_EDITOR || UNITY_STANDALONE
             isMobilePlatform = false;
        #else
             isMobilePlatform = true;
        #endif
    }

    private void Update()
    {
        if(!isMobilePlatform)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isDragging = true;
                tapPoint = Input.mousePosition;
            }
            else if (Input.GetMouseButtonUp(0))
                ResetSwype();
        }
        else
        {
            if(Input.touchCount>0)
            {
                if (Input.touches[0].phase == TouchPhase.Began)
                {
                    isDragging = true;
                    tapPoint = Input.touches[0].position;
                }
                else if (Input.touches[0].phase == TouchPhase.Canceled ||
                    Input.touches[0].phase == TouchPhase.Ended)
                    ResetSwype();
            }
        }
        CalculateSwype();
    }

    void CalculateSwype()
    {
        swypeDelta = Vector2.zero;
        if(isDragging)
        {
            if (!isMobilePlatform && Input.GetMouseButton(0))
                swypeDelta = (Vector2)Input.mousePosition - tapPoint;
            else if (Input.touchCount > 0)
                swypeDelta = Input.touches[0].position - tapPoint;
        }

        if(swypeDelta.magnitude >minSwypeDelta)
        {
            if(SwypeEvent!=null)
            {
                if (Mathf.Abs(swypeDelta.x) > Mathf.Abs(swypeDelta.y))
                    SwypeEvent(swypeDelta.x < 0 ? SwypeType.LEFT : SwypeType.RIGHT);
                else
                    SwypeEvent(swypeDelta.y > 0 ? SwypeType.UP : SwypeType.DOWN);
            }
            ResetSwype();
        }
    }
    void ResetSwype()
    {
        isDragging = false;
        tapPoint = swypeDelta = Vector2.zero;
    }
}
