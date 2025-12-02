using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float jumpForce;
    public float speed;

    
    public bool isGrounded;

    
    Animator anim;
    public bool moving;
    public bool attack;


   

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


        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x -= speed;
            newScale.x = -currentScale;
            moving = true;
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x += speed;
            newScale.x = currentScale;
            moving = true;
        }


        if(Input.GetKey("e") && isGrounded)
        {
            attack = true;
        }

        if(Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            moving = false;

        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("attack") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
        {
            attack = false;
        }

        anim.SetBool("isMoving", moving);
        anim.SetBool("isAttacking", attack);

        transform.position = newPosition;
        transform.localScale = newScale;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            Debug.Log("i hit the ground");
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
