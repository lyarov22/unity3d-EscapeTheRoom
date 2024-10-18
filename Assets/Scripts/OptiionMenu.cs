using System;
using System.Collections;
using System.Collections.Generic;
 
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptiionMenu : MonoBehaviour
{
    public void BackOption()
    {

        PlayerPrefs.SetString("previousScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("SettingsScene");
    }

    public void ReturnToPreviousScene()
    {
        string previousScene = PlayerPrefs.GetString("previousScene");

        SceneManager.LoadScene(previousScene);
    }
}
