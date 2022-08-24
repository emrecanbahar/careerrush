using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu1 : MonoBehaviour
{
    public void Play_Again()
    {
        SceneManager.LoadScene("Scenes/game");

        Time.timeScale = 1.0f;
    }
    public void NexttLevelButton()
    {
        Application.LoadLevel(1);
        // SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
