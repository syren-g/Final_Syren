using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public float countdownTime = 60f;
    public TextMeshPro TimerText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdownTime -= Time.deltaTime;

        if (countdownTime < 0)
            countdownTime = 0;

        TimerText.text = "Time Left: " + Mathf.CeilToInt(countdownTime);

        if (countdownTime == 0)
        {
            Debug.Log("Time's up!");
        }
    }
}
