using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBuilder : MonoBehaviour
{
    public float Timer = 4;

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            if (GameObject.FindGameObjectWithTag("Coin") != null)
            {
                GameObject.FindGameObjectWithTag("Coin").GetComponent<CoinManager>().CreateCoin();
            }
            else
            {
                Instantiate(Resources.Load("Coin"), new Vector3(12, Random.Range(-3f, 2f), 0), Quaternion.identity);
            }

            Timer = 4;
        }
    }
}
