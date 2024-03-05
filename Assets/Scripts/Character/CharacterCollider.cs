using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            gameObject.GetComponent<CharacterMovement>().jumpCount = 0;
            gameObject.GetComponent<CharacterCounter>().scoreCount++;
        }
        else if(collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            gameObject.GetComponent<CharacterCounter>().coinCount++;
            GetComponent<Rigidbody2D>().mass = 0.5f;
        }
    }
}
