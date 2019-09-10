using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float runSpeed = 8f;
    public float jumpSpeed = 10f;
    float hMove = 0f;
    bool jumping = false;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hMove = Input.GetAxis("Horizontal");

        if (rb.velocity.y < 1 && rb.velocity.y >= 0)
        {
            if (Input.GetAxis("Jump") > 0 && rb.position.y < 0)
            {
                jumping = true;
            }
        }
    }

    void FixedUpdate()
    {
        if (jumping)
        {
            rb.velocity = new Vector2(hMove * runSpeed, jumpSpeed);
            jumping = false;
        }
        else
        {
            rb.velocity = new Vector2(hMove * runSpeed, rb.velocity.y);
        }
        
        if ((rb.position.x > 8 && rb.velocity.x > 0) || (rb.position.x < -8 && rb.velocity.x < 0))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
}
