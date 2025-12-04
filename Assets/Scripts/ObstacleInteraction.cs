using UnityEngine;

public class ObstacleInteraction : MonoBehaviour
{
   
    public int score = 0;

     
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player died");
            Destroy(gameObject); 
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            Debug.Log("Point gained");
            Destroy (collision.gameObject);
            score += 1;
        }
       
    }

   
    
   

  }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    