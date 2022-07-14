using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect2 : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]

    private float fadet;
    public GameObject imagee;
    private Image image;


    void Start()
    {
        image = GetComponent<Image>();
        imagee.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            imagee.SetActive(true);
            StartCoroutine(FadeOut(0, 1));
        }

        
    }

    private IEnumerator FadeOut(float start, float end)
    {
        float currentT = 0.0f;
        float percent = 0.0f;

        while (percent < 1)
        {
            currentT += Time.deltaTime;
            percent = currentT / fadet;

            Color color = image.color;
            color.a = Mathf.Lerp(start, end, percent);

            image.color = color;

            yield return null;
        }
    }
}
