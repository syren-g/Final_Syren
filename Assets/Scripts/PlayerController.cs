using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float speed;
    
    public bool isGrounded;

    public float teleportDistance = 1f;

    Animator anim;
    public bool moving;

    public float xMin = -7f;
    public float xMax = 7f;

    public AudioSource walkingAudio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;


        Vector3 newScale = transform.localScale;
        float currentScale = Mathf.Abs(transform.localScale.x);

        if (moving)
        {
            if(!walkingAudio.isPlaying)
            {
                walkingAudio.Play();
            }
        }
        else
        { if(walkingAudio.isPlaying)
            {
                walkingAudio.Stop();
            }
        }

        if (Input.GetKey("a"))
        {
            newPosition.x -= speed;
            newScale.x = -currentScale;
            moving = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 facingDirection = newScale.x > 0 ? Vector3.right : Vector3.left;
            newPosition += facingDirection * teleportDistance;
            newPosition.x = Mathf.Clamp(newPosition.x, xMin, xMax);
        }

        if (Input.GetKey("d"))
        {
            newPosition.x += speed;
            newScale.x = currentScale;
            moving = true;
        }



        if (Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            moving = false;

        }

     

        anim.SetBool("isMoving", moving);
       

        transform.position = newPosition;
        transform.localScale = newScale;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            isGrounded = false;
        }
    }

}
