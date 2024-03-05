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
        float 
        Instantiate(gameObject, new Vector3(0, Random(1f, 10f), 0), Quaternion.identity);
    }
}
