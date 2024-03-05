using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame(){
        Debug.Log("Start Game");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
