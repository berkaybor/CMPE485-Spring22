using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartNormalGame()
    {
        Globals.difficulty = 1;
        SceneManager.LoadScene("MainScene");
    }

    public void StartHardGame()
    {
        Globals.difficulty = 2;
        SceneManager.LoadScene("MainScene");
    }
}
