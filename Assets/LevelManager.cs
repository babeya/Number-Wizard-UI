﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{
    public void LoadLevel(string name) 
    {
        SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Ne me quittes pas ...");
    }
	
}
