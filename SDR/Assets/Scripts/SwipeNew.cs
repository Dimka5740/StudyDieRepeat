using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeNew : MonoBehaviour
{
    //public GameObject Card;
    public StickerLogic sl;
    Image img;
    float fMovingSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        img = GameObject.Find("Sticker").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && sl.isMouseOver)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            img.transform.position = pos;
        }
        else
        {
            img.transform.position = Vector2.MoveTowards(img.transform.position, new Vector2(0, 0), fMovingSpeed);
        }
        //YES side
        if (img.transform.position.x > 1)
        {
            img.color = Color.green;
            if (!Input.GetMouseButton(0))
            {
                sl.InduceRight(50, 50, 50, 50);
            }
        }
        //NO side
        else if (img.transform.position.x < -1)
        {
            img.color = Color.red;
            if (!Input.GetMouseButton(0))
            {
                //sl.InduceLeft();
            }
        }
        else img.color = Color.white;
    }
}

