using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text text;
    //public Data data;
    //public SwipeNew swipeNew;
   
    // Start is called before the first frame update
    void Start()
    {
        //SwypeController.SwypeEvent += NewGame;
        print(Data.text);
        text.text = Data.text;
    }
    //private void NewGame(SwypeController.SwypeType type)
    //{
    //    //SceneManager.LoadScene(0);
    //}
}
