using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starter : MonoBehaviour
{

    public GameObject cursor;
    public GameObject starter;
    public Image background;
    

    public float fadeDuration = 15f;
    private float fadeTimer = 5f;
    private bool isFading = false;

    void Start()
    {
        // Запуск плавного исчезновения фона UI
        StartFade();
    }
    private void Update()
    {
        StartCoroutine(DelayedAction());
        if (isFading)
        {
            fadeTimer += Time.deltaTime;
            float alpha = 1f - Mathf.Clamp01(fadeTimer / fadeDuration); // Изменение прозрачности от 1 до 0

            Color backgroundColor = background.color;
            backgroundColor.a = alpha; // Установка нового значения альфа-канала
            background.color = backgroundColor;

            if (fadeTimer >= fadeDuration)
            {
                isFading = false;
            }
        }
    }

    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(3f); // Задержка в 2 секунды
         cursor.SetActive(true);
         starter.SetActive(false);                              // Выполнить задержанное действие
    }
    void StartFade()
    {
        isFading = true;
        fadeTimer = 0f;
    }
}
