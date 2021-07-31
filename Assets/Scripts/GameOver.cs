using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Game is over");
            gameObject.tag = "End";
            Invoke("ReloadLevel", 1);
        }
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
