using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    bool levelFinished = false;
    public float delay = 1f;
    public GameObject completeUI;
    public void CompletedLevel()
    {
        completeUI.SetActive(true);
         
    }
    public void GameOver()
    {
        if (levelFinished == false)
        {
            levelFinished = true;
            Invoke("Restart", delay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
