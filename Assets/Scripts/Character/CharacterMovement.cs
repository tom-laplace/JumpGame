using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public int jumpCount = 0;

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
    }

    public void Jump()
    {
        GetComponent<Animator>().SetTrigger("Jump");
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
