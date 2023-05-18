using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info_Src : MonoBehaviour
{

    private bool isPlayerInsideTrigger = false;

 
    void Update()
    {
        if (isPlayerInsideTrigger)
        {
            // Действия, когда игрок находится внутри триггера
            SceneManager.LoadScene("Level_1");
        }
         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTrigger = true;
            // Действия, когда игрок входит в триггер
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTrigger = false;
            // Действия, когда игрок выходит из триггера
        }
    }
}
