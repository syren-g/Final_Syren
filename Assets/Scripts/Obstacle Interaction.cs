using UnityEngine;

public class ObstacleInteraction : MonoBehaviour
{

    public int score = 0;

     void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            AddPoint(collision.gameObject);
        }
    }


    void Die()
    {
        Debug.Log("Player died");
        Destroy(gameObject);


    }
    
    void AddPoint(GameObject pointObject)
    {
        score++;
        Debug.Log("You gained a point! Score: " + score);
        Destroy(pointObject);
    }


  }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    