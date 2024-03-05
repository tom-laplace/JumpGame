using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = GameObject.Find("Timer").GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer.text = "Time : " + Mathf.Round(Time.timeSinceLevelLoad).ToString() + "s";
    }
}
