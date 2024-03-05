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
            gameObject.GetComponent<CharacterCounter>().scoreCount++;
            gameObject.GetComponent<JumpController>().isCollidingWithPlatform = true;
        }
        else if(collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            gameObject.GetComponent<CharacterCounter>().coinCount++;
        }
    }
}
