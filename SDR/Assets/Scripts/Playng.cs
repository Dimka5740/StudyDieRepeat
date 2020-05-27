﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Playng : MonoBehaviour
{
    // public GameObject cube;
    public float speed, angle;
    Text text1;
    //RectTransform rect, rectCube;
    bool isRotation = false;
    Quaternion rotationY;
    void Start()
    {
        SwypeController.SwypeEvent += CheckSwype;
        text1 = GetComponentsInChildren<Text>()[0];
        //rect = GetComponent<RectTransform>();
        //rectCube = cube.GetComponent<RectTransform>();

    }
    void CheckSwype(SwypeController.SwypeType type)
    {
        switch (type)
        {
            case SwypeController.SwypeType.LEFT: speed = Mathf.Abs(speed); isRotation = true; break;
            case SwypeController.SwypeType.RIGHT: speed = Mathf.Abs(speed) * -1; isRotation = true; break;
        }
    }

    void FixedUpdate()
    {
        if (isRotation)
        {

            angle += speed;
            rotationY = Quaternion.AngleAxis(angle, Vector3.up);
            transform.rotation = rotationY;
            if (Mathf.Abs(angle) % 180 == 0)
            {
                isRotation = false;
                //text1.text = "fdggdg";
            }
            //rect.transform.Rotate(0, speed, 0);
            //rectCube.transform.Rotate(0, speed, 0);
            //if (Mathf.Abs(y - rectCube.transform.rotation.y) >= 0.9999999)//да простят меня боги за такой костыль
            //{
            //    isRotation = false;
            //    rectCube.transform.rotation = new Quaternion(0, (float)Math.Round(Convert.ToDouble(rectCube.transform.rotation.y)), 0, 0);
            //}
            //print(rect.transform.rotation.y);
        }
    }
}
