using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ObstacleInteraction : MonoBehaviour
{
    public TextMeshPro ScoreText;
    public int Score = 0;

    public AudioSource sourceone;
    public AudioClip yumClip;

    public AudioSource sourcetwo;
    public AudioClip bleghClip;
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
            sourcetwo.PlayOneShot(bleghClip);
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            Debug.Log("Point gained");
            Destroy (collision.gameObject);
            Score += 1;
            UpdateScore();
            sourceone.PlayOneShot(yumClip);
        }
        else if (collision.gameObject.CompareTag("Enemy Special"))
        {
            Debug.Log("Points Lost");
            Score -= 2;
            Destroy(collision.gameObject);
            UpdateScore();
            sourcetwo.PlayOneShot(bleghClip);
        }
        else if (collision.gameObject.CompareTag("Point Special"))
        {
            Debug.Log("Point gained");
            Destroy(collision.gameObject);
            Score += 2;
            UpdateScore();
            sourceone.PlayOneShot(yumClip);
        }

    }
    public void UpdateScore()
    {
        ScoreText.text = "SCORE: " + Score;
    }




}
   
    