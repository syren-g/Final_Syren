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
            Score -= 1;
            Destroy(collision.gameObject);
            UpdateScore();
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            Debug.Log("Point gained");
            Destroy (collision.gameObject);
            Score += 1;
            UpdateScore();
        }
        else if (collision.gameObject.CompareTag("Enemy Special"))
        {
            Debug.Log("Points Lost");
            Score -= 2;
            Destroy(collision.gameObject);
            UpdateScore();
        }
        else if (collision.gameObject.CompareTag("Point Special"))
        {
            Debug.Log("Point gained");
            Destroy(collision.gameObject);
            Score += 2;
            UpdateScore();
        }

    }
    public void UpdateScore()
    {
        ScoreText.text = "Score: " + Score;
    }




}
   
    