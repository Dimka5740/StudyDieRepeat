using UnityEngine;
using IJunior.TypedScenes;

public class LoadScene : MonoBehaviour
{
    public GameObject learning, buttonPlay, buttonExit;
    bool isFirstGame;
    public void OnClickYes()
    {
        isFirstGame = true;
        learning.SetActive(false);
        buttonPlay.SetActive(true);
        buttonExit.SetActive(true);
        Game.Load(isFirstGame);
    }
    public void OnClickNo()
    {
        isFirstGame = false;
        learning.SetActive(false);
        buttonPlay.SetActive(true);
        buttonExit.SetActive(true);
        Game.Load(isFirstGame);
    }
    public void Load()
    {
        learning.SetActive(true);
        buttonPlay.SetActive(false);
        buttonExit.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
