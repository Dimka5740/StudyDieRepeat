﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickerLogic : MonoBehaviour
{
    Image imgHealth, imgPsyhic, imgStudy, imgSocio; // показатели, которые менять будем
    //int rhe, rps, rst, rso; // значения на которые менять для Yes
   // int lhe, lps, lst, lso; // для No
    public bool isMouseOver = false;
    private void OnMouseOver()
    {
        isMouseOver = true;
    }
    private void OnMouseExit()
    {
        isMouseOver = false;
    }
    private void FindIndicators()
    {
        imgHealth = GameObject.Find("ImageHealth (1)").GetComponent<Image>();
        imgPsyhic = GameObject.Find("ImagePsychic (1)").GetComponent<Image>();
        imgStudy = GameObject.Find("ImageStudy (1)").GetComponent<Image>();
        imgSocio = GameObject.Find("ImageSocio (1)").GetComponent<Image>();
    }
    public void InduceRight(int rhe, int rps, int rst, int rso)
    {
        //TODO do something for YES
        FindIndicators();
        imgHealth.fillAmount = imgHealth.fillAmount + rhe*0.001f;
        imgPsyhic.fillAmount = imgPsyhic.fillAmount + rps * 0.001f;
        imgStudy.fillAmount = imgStudy.fillAmount + rst * 0.001f;
        imgSocio.fillAmount = imgSocio.fillAmount + rso * 0.001f;
    }
    public void InduceLeft(int lhe, int lps, int lst, int lso)
    {
        //TODO do something for NO
        FindIndicators();
        imgHealth.fillAmount = (float)(imgHealth.fillAmount + (float)lhe * 0.01);
        imgPsyhic.fillAmount = (float)(imgPsyhic.fillAmount + (float)lps * 0.01);
        imgStudy.fillAmount = (float)(imgStudy.fillAmount + (float)lst * 0.01);
        imgSocio.fillAmount = (float)(imgSocio.fillAmount + (float)lso * 0.01);
    }
}
