using UnityEngine;
using IJunior.TypedScenes;
using UnityEngine.UI;

public class GameEntry : MonoBehaviour, ISceneLoadHandler<bool>
{
    public GameObject learning;
    public Text textOfCard;
    public Image sticker;
    public Image sticker2;
    public GameObject stats;


    private int stageOfLearning;
    private Text textLearning;
    private RectTransform rectLearning;
    
    public void Clicked()
    {
        stageOfLearning++;
        
    }
    public void AboutText()
    {
        stats.SetActive(false);
        sticker.enabled = false;
        sticker2.enabled = false;
        rectLearning.anchorMin = new Vector2(0.05f, 0.20f);
        rectLearning.anchorMax = new Vector2(0.95f, 0.5f);
        textLearning.text = "Это текст с описанием происходящей ситуации. Сначала Вам будет предложено сделать выбор, который повлияет на твои показатели, затем то, что из этого вышло. Для положительного выбора - свайп вправо, для отрицательного - влево. Удачи!";
        textOfCard.enabled = true;
    }
    public void AboutStickers()
    {
        stats.SetActive(false);
        sticker.enabled = true;
        sticker2.enabled = true;
        rectLearning.anchorMin = new Vector2(0.05f, 0.5f);
        rectLearning.anchorMax = new Vector2(0.95f, 0.72f);
        textLearning.text = "Это стикеры с изображениями. Они подобраны под тематику каждой из ситуации и перемещаются влево или вправо в зависимости от типа свайпа.";
        textOfCard.enabled = false;
    }
    public void AboutStats()
    {
        textOfCard.enabled = false;
        sticker.enabled = false;
        sticker2.enabled = false;

    }
    public void OnSceneLoaded(bool isFirstGame)
    {
        if (isFirstGame == true)
        {
            learning.SetActive(true);
            stageOfLearning = 0;
            AboutStats();
        }
        else
        {
            stageOfLearning = 5;
        }
    }
    private void Start()
    {
        textLearning = learning.transform.GetComponentInChildren<Text>();
        rectLearning = learning.transform.GetComponent<RectTransform>();
        
    }
    private void Update()
    {
        switch (stageOfLearning)
        {
            case 0: AboutStats(); break;
            case 1: AboutStickers(); break;
            case 2: AboutText(); break;
            default:
                stats.SetActive(true);
                sticker.enabled = true;
                sticker2.enabled = true;
                textOfCard.enabled = true;
                learning.SetActive(false);
                break;
        }
    }
}
