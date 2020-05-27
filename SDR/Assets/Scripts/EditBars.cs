using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class EditBars : MonoBehaviour
{
    public Image barHealth, barPsychic, barStudy, barSoc;
    /// <summary>
    /// Принимает значения, на которые изменятся шкалы.
    /// </summary>
    /// <param name="valueForHealth">float</param>
    /// <param name="valueForPschic">float</param>
    /// <param name="valueForStudy">float</param>
    /// <param name="valueForSoc">float</param>
    public void EditBar(float valueForHealth, float valueForPschic, float valueForStudy,float valueForSoc)
    {
        try
        {
            barHealth.GetComponent<RectTransform>().anchorMax += new Vector2(0, valueForHealth);
            barPsychic.GetComponent<RectTransform>().anchorMax += new Vector2(0, valueForPschic);
            barStudy.GetComponent<RectTransform>().anchorMax += new Vector2(0, valueForStudy);
            barSoc.GetComponent<RectTransform>().anchorMax += new Vector2(0, valueForSoc);
        }
        catch (System.Exception e) { print(e.Message); }
        //RectTransform rectTransform = bar.GetComponent<RectTransform>();
        // rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 0, 300);
        //bar.GetComponent<RectTransform>().offsetMax = new Vector2(0, -290);
    }
}
