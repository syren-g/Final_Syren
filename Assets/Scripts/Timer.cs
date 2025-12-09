using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public float countdownTime = 60f;
    public bool timerIsRunning = false;

    public TextMeshPro TimerText;
    public TextMeshPro finalScoreText;

    public ObstacleInteraction scoreScript;
    public PlayerController player;
    void Start()
    {
        timerIsRunning = true;
        finalScoreText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (countdownTime > 0)
            {
                countdownTime -= Time.deltaTime;
                DisplayTime(countdownTime);
            }
            else
            {
                countdownTime = 0;
                timerIsRunning = false;

                TimeUp();
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; 

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        TimerText.text = "TIME LEFT: " + seconds.ToString();
    }
    void TimeUp()
    {
        
        finalScoreText.gameObject.SetActive(true);
        finalScoreText.text = "TIMES UP! FINAL SCORE: " + scoreScript.Score;

        
        Time.timeScale = 0f;
        player.enabled = false;
    }
}
