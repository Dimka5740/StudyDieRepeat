using UnityEngine;

public class ShowInfornation : MonoBehaviour
{
    public GameObject infoAbouGame;
    public GameObject buttonPlay;
    public GameObject buttonExit;
    public void ShowInfo()
    {
        if (infoAbouGame.activeSelf == false)
        {
            infoAbouGame.SetActive(true);
            buttonPlay.SetActive(false);
            buttonExit.SetActive(false);
        }
        else
        {
            infoAbouGame.SetActive(false);
            buttonPlay.SetActive(true);
            buttonExit.SetActive(true);
        }
    }
    void Start()
    {
    }

}
