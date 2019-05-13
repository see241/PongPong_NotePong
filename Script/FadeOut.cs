using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadein : MonoBehaviour
{
    public float animTime = 2f;

    private Image fadeImage;

    private float start = 1f;
    private float end = 0f;
    private float time = 0f;

    private bool isPlaying = false;

    void Awake()
    {
        fadeImage = GetComponent<Image>();
    }
    public void StartFadeAnim()
    {
        if (isPlaying == true)
            return;

        StartCoroutine("PlayFadein");
    }

    IEnumerator PlayFadein()
    {
        isPlaying = true;

        Color color = fadeImage.color;
        time = 0f;
        color.a = Mathf.Lerp(start, end, time);

        while (color.a > 0f)
        {
            time += Time.deltaTime / animTime;

            color.a = Mathf.Lerp(start, end, time);

            fadeImage.color = color;

            yield return null;
        }

        isPlaying = false;

        Destroy(this.gameObject);
    }
}
	
	
