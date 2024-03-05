using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //get the pause text to display if the game is paused
    public TMPro.TextMeshProUGUI pauseText;

    void Start()
    {
        pauseText.gameObject.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                pauseText.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                pauseText.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
