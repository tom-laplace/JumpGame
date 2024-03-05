using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    Vector3 initialPosition = new(-8.8f, -2.15f, -0.006842589f);

    void Update()
    {
        if(gameObject.transform.position.y < -5.0f || gameObject.transform.position.x < -10.0f)
        {
            StartCoroutine(LoadGameOver());
        }
    }

    IEnumerator LoadGameOver(){
        yield return new WaitForSeconds(1);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game Over");
    }
}
