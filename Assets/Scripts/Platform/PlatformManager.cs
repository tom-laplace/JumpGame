using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    void Update()
    {
        
    }

    public void DestroyPlatform()
    {
        Destroy(gameObject);
    }

    public void CreatePlatform()
    {
        float randomHeight = Random.Range(1f, 10f);
        Instantiate(gameObject, new Vector3(0, randomHeight, 0), Quaternion.identity);
    }
}
