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
            // ��������, ����� ����� ��������� ������ ��������
            SceneManager.LoadScene("Level_1");
        }
         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTrigger = true;
            // ��������, ����� ����� ������ � �������
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTrigger = false;
            // ��������, ����� ����� ������� �� ��������
        }
    }
}
