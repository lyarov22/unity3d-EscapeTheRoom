using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Starter : MonoBehaviour
{
    public GameObject cursor;
    public GameObject starter;
    public Image background;
    public TextMeshProUGUI textHistory;

    public float fadeDuration = 3f;
    public float fadeDelay = 2f;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            StartCoroutine(FadeSequence());
        }
    }

    private IEnumerator FadeSequence()
    {
        yield return new WaitForSeconds(fadeDelay);

        float elapsedTime = 0f;
        Color startColor = background.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 0f);

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;

            float t = Mathf.Clamp01(elapsedTime / fadeDuration);
            float alpha = Mathf.Lerp(startColor.a, endColor.a, t);

            background.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
            textHistory.color = new Color(textHistory.color.r, textHistory.color.g, textHistory.color.b, alpha);

            yield return null;
        }

        cursor.SetActive(true);
        starter.SetActive(false);
    }
}