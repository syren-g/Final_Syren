using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ObstacleInteraction : MonoBehaviour
{
    public TextMeshPro ScoreText;
    public int Score = 0;

    void Start()
    {
        UpdateScore();
    }

     void Update()
    {
       
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Points Lost");
            score -= 1;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            Debug.Log("Point gained");
            Destroy (collision.gameObject);
            score += 1;
        }
       
    }
    public void UpdateScore()
    {
        ScoreText.text = "Score: " + Score;
    }




}
   
    