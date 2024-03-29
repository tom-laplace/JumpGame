using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    readonly float platformSpeed = 4f;
    
    void Update()
    {
        if (gameObject.transform.position.x < -30.0f)
        {
            DestroyPlatform();
        }

        gameObject.transform.position += platformSpeed * Time.deltaTime * Vector3.left;
    }

    public void DestroyPlatform()
    {
        Destroy(gameObject);
    }

    public void CreatePlatform()
    {
        float randomHeight = Random.Range(-3f, 2f);
        Instantiate(gameObject, new Vector3(12, randomHeight, 0), Quaternion.identity);
    }
}
