using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCounter : MonoBehaviour
{
    public int scoreCount = 0;
    public int coinCount = 0;
    public TMPro.TextMeshProUGUI CoinCounter;
    public TMPro.TextMeshProUGUI ScoreCounter;

    public void Start()
    {
        CoinCounter = GameObject.Find("CoinCounter").GetComponent<TMPro.TextMeshProUGUI>();
        ScoreCounter = GameObject.Find("ScoreCounter").GetComponent<TMPro.TextMeshProUGUI>();
    }

    public void Update()
    {
        CoinCounter.text = "Coins : " + coinCount.ToString();
        ScoreCounter.text = "Score : " + scoreCount.ToString();
    }

    public void ResetCounts()
    {
        scoreCount = 0;
        coinCount = 0;
    }
}
