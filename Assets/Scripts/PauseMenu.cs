using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject HUD;

    public GameObject PanelUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PanelUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        HUD.active = true;
    }

    private void Pause()
    {
        PanelUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        HUD.active = false;
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("MenuScene");
    }

}
