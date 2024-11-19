using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private float score;
    private float highScore;
    private float winningScore = 10000;

    [SerializeField] private TextMeshProUGUI scoreCounter;
    [SerializeField] private TextMeshProUGUI highScoreCounter;
    [SerializeField] private GameObject scoreGameobject;
    [SerializeField] private GameObject highscoreGameobject;

    private void Update()
    {
        if (scoreCounter != null)
        {
            scoreCounter.text = score.ToString();
            highScoreCounter.text = highScore.ToString();
        }

        if (SceneManager.GetActiveScene().name != "MainMenu")
        {
            highscoreGameobject.SetActive(false);
            scoreGameobject.SetActive(true);
        }
        else
        {
            scoreGameobject.SetActive(false);
            highscoreGameobject.SetActive(true);
        }

        if (score > winningScore)
        {
            SceneManager.LoadScene("Win");
        }
    }

    
    public void AddToScore(float addedScore)
    {
        score += addedScore;

        if (score > highScore) { highScore = score; }
    }
}
