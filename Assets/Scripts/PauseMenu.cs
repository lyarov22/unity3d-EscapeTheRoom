using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject Camera1;
    public GameObject Camera2;

    public GameObject HUD;

    public GameObject PanelUI;

    private void Start()
    {
        Component cameraScript = Camera1.GetComponent<CameraController>();
    }

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

        Vector3 pos1 = Camera1.transform.position;
        Camera2.transform.position = pos1;

    }
    public void Resume()
    {
        PanelUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        HUD.active = true;
        Cursor.visible = false;
    }

    private void Pause()
    {
        
        PanelUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        HUD.active = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("MenuScene");
    }

}
