using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    Vector3 initialPosition = new(-8.8f, -2.15f, -0.006842589f);

    void Update()
    {
        if(gameObject.transform.position.y < -5.0f)
        {
            ResetCharacter();
        }
    }
    public void ResetCharacter()
    {
        Destroy(gameObject);
        Instantiate(gameObject, initialPosition, Quaternion.identity);
    }
}
