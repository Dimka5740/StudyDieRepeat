using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Classes : MonoBehaviour
{
    public string Theme;
    public string Text;
    public Classes(string Theme, string Text)
    {
        this.Theme = Theme;
        this.Text = Text;
    }
}

public class StoryEvent : Classes
{
    public string YesText;
    public int YesHealth;
    public int YesPsyhic;
    public int YesStudy;
    public int YesSosiety;
    public string NoText;
    public int NoHealth;
    public int NoPsyhic;
    public int NoStudy;
    public int NoSosiety;
    public bool Branch;

    public StoryEvent(string Theme, string Text,string YesText, int YesHealth,int YesPsyhic, int YesStudy, int YesSosiety, string NoText, int NoHealth, int NoPsyhic, int NoStudy, int NoSosiety,bool Branch) :base(Theme, Text)
    {
        this.YesText = YesText;
        this.YesHealth = YesHealth;
        this.YesPsyhic = YesPsyhic;
        this.YesStudy = YesStudy;
        this.YesSosiety = YesSosiety;
        this.NoText = NoText;
        this.NoHealth = NoHealth;
        this.NoPsyhic = NoPsyhic;
        this.NoStudy = NoStudy;
        this.NoSosiety = NoSosiety;
        this.Branch = Branch;
    }
}

public class RandomEvent : Classes
{
    int YesHealth;
    int YesPsyhic;
    int YesStudy;
    int YesSosiety;
    public RandomEvent(string Theme, string Text, int YesHealth, int YesPsyhic, int YesStudy, int YesSosiety) : base(Theme, Text)
    {
        this.YesHealth = YesHealth;
        this.YesPsyhic = YesPsyhic;
        this.YesStudy = YesStudy;
        this.YesSosiety = YesSosiety;
    }
}

public class RandomChoiceEvent : Classes
{
    string YesText;
    int YesHealth;
    int YesPsyhic;
    int YesStudy;
    int YesSosiety;
    string NoText;
    int NoHealth;
    int NoPsyhic;
    int NoStudy;
    int NoSosiety;

    public RandomChoiceEvent (string Theme, string Text, string YesText, int YesHealth, int YesPsyhic, int YesStudy, int YesSosiety, string NoText, int NoHealth, int NoPsyhic, int NoStudy, int NoSosiety) : base(Theme, Text)
    {
        this.YesText = YesText;
        this.YesHealth = YesHealth;
        this.YesPsyhic = YesPsyhic;
        this.YesStudy = YesStudy;
        this.YesSosiety = YesSosiety;
        this.NoText = NoText;
        this.NoHealth = NoHealth;
        this.NoPsyhic = NoPsyhic;
        this.NoStudy = NoStudy;
        this.NoSosiety = NoSosiety;
    }
}