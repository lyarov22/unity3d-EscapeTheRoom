using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public Camera Camera1;
     

    public GameObject HUD;
    private CameraController script;
    public GameObject PanelUI;
    // Update is called once per frame

    int sceneIndex;

    private void Start()
    {
         sceneIndex = SceneManager.GetActiveScene().buildIndex;

         script = Camera1.GetComponent<CameraController>();
    }

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
       
        script.enabled = true;
        Cursor.visible = false;
    }

    private void Pause()
    {
        PanelUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        HUD.active = false;
        
        script.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Restart()
    {
        Resume();
        SceneManager.LoadScene(sceneIndex);
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("MenuScene");
    }

}
