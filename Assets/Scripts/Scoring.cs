using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public int score;
    public int turns = 10;
    public TextMeshProUGUI scoring;
    public TextMeshProUGUI turnsTxt;
    public GameObject LossScreen;
    public GameObject VictoryScreen;
    public GameObject GameCanvas;

    private void Update()
    {
        scoring.text = "Score: " + score.ToString();
        turnsTxt.text = "Moves :" + turns.ToString();

        Loss();
        Victory();

    }

    public void Loss()
    {
        if (turns <= 0)
        {
            GameCanvas.SetActive(false);
            LossScreen.SetActive(true);
        }
    }

    public void Victory()
    {
        if (score == 10)
        {
            GameCanvas.SetActive(false);
            VictoryScreen.SetActive(true);
        }
    }
}
