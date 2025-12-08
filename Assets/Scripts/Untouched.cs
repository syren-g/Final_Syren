using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Untouched : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemey Hit Ground");
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            Debug.Log("Point Hit Ground");
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Point Special"))
        {
            Debug.Log("Point Hit Ground");
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Enemy Special"))
        {
            Debug.Log("Enemy Hit Ground");
            Destroy(collision.gameObject);
        }
    }
}


    