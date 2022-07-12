using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextClickTwinkle : MonoBehaviour
{
    [SerializeField]
    private float lerpTime = 0.1f;
    private TextMeshProUGUI textclick;

    private void Awake()
    {
        textclick = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        StartCoroutine("ColorLerpLoop");
    }

    private IEnumerator ColorLerpLoop()
    {
        while(true)
        {
            yield return StartCoroutine(ColorLerp(Color.white, Color.red));
            yield return StartCoroutine(ColorLerp(Color.red, Color.white));
        }
    }

    private IEnumerator ColorLerp(Color startcolor,Color endcolor)
    {
        float cTime = 0.0f;
        float percent = 0.0f;

        while (percent < 1)
        {
            cTime += Time.deltaTime;
            percent = cTime / lerpTime;

            textclick.color = Color.Lerp(startcolor, endcolor, percent);
            yield return null;

        }
    }
}
