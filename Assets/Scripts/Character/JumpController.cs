using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    [Header("Jump Settings")]
    [SerializeField] int jumpPower;
    [SerializeField] float fallMultiplier;
    [SerializeField] float jumpTime;
    [SerializeField] float jumpMultiplier;

    Rigidbody2D rb;
    UnityEngine.Vector2 vecGravity;

    public bool isCollidingWithPlatform;

    bool isJumping;
    float jumpCounter;

    void Start()
    {
        vecGravity = new(0, -Physics2D.gravity.y);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isCollidingWithPlatform)
        {
            rb.velocity = new(rb.velocity.x, jumpPower);
            gameObject.GetComponent<Animator>().SetTrigger("Jump");
            isCollidingWithPlatform = false;
            isJumping = true;
            jumpCounter = 0;
        }

        if (rb.velocity.y > 0 && isJumping)
        {
            jumpCounter += Time.deltaTime;
            if (jumpCounter > jumpTime) isJumping = false;

            float t = jumpCounter / jumpTime;
            float currentJumpMultiplier = jumpMultiplier;

            if (t > 0.5f)
            {
                currentJumpMultiplier = jumpMultiplier * (1 - t);
            }

            rb.velocity += currentJumpMultiplier * Time.deltaTime * vecGravity;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
            jumpCounter = 0;

            if (rb.velocity.y > 0)
            {
                rb.velocity = new(rb.velocity.x, rb.velocity.y * 0.6f);
            }
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity -= fallMultiplier * Time.deltaTime * vecGravity;
        }
    }
}
