using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Make character move to the right 
        transform.position += Vector3.right * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("Jump");
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
