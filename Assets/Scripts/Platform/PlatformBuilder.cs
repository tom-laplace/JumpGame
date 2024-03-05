using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBuilder : MonoBehaviour
{
    public float Timer = 2;

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            GameObject.FindGameObjectWithTag("Platform").GetComponent<PlatformManager>().CreatePlatform();
            Timer = 2;
        }
    }
}
