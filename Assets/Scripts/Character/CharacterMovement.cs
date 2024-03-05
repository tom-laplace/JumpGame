using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public int jumpCount = 0;
    Rigidbody2D rb;
    Vector2 vecGravity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < 2)
            {
                Jump();
                jumpCount++;
            }
        }

        if(rb.velocity.y < 0)
        {
            rb.velocity -= 0.5f * Time.deltaTime * vecGravity;
        }
    }

    public void Jump()
    {
        GetComponent<Animator>().SetTrigger("Jump");
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
