using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Image bar;

    public void EditBar()
    {
        RectTransform rectTransform = bar.GetComponent<RectTransform>();
        // rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 0, 300);
        Vector2 vector2 = bar.rectTransform.sizeDelta;
        print(vector2.x);
        print(vector2.y);
        bar.GetComponent<RectTransform>().offsetMax = new Vector2(0, -290);
    }
   
}
