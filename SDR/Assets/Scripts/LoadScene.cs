using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject learning, buttonPlay, buttonExit;
    //bool isFirstGame;

    private void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickYes()
    {
        Data.isFirstGame = true;
        GoToGame();
    }

    public void OnClickNo()
    {
        Data.isFirstGame = false;
        GoToGame();
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
