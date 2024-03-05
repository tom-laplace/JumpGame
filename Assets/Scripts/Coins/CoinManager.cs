using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    readonly float coinSpeed = 4f;
    
    void Update()
    {
        if (gameObject.transform.position.x < -30.0f)
        {
            DestroyCoin();
        }

        gameObject.transform.position += coinSpeed * Time.deltaTime * Vector3.left;
    }

    public void DestroyCoin()
    {
        Destroy(gameObject);
    }

    public void CreateCoin()
    {
        float randomHeight = Random.Range(-3f, 2f);
        Instantiate(gameObject, new Vector3(12, randomHeight, 0), Quaternion.identity);
    }
}
