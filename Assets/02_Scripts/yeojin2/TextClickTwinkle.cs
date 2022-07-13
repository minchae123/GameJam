using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextClickTwinkle : MonoBehaviour
{
    public float fadetime = 0.1f;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        StartCoroutine("TwinkleLoop");
    }

    private IEnumerator TwinkleLoop()
    {
        while (true)
        {
            yield return StartCoroutine(FadeEffect(1, 0));
            yield return StartCoroutine(FadeEffect(0, 1));
        }

    }

    private IEnumerator FadeEffect(float start,float end)
    {
        float currentT = 0.0f;
        float percent = 0.0f;

        while(percent<1)
        {
            currentT += Time.deltaTime;
            percent = currentT / fadetime;

            Color color = spriteRenderer.color;
            color.a = Mathf.Lerp(start, end, percent);

            spriteRenderer.color = color;

            yield return null;
        }
    }
}
