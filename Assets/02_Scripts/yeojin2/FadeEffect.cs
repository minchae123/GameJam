using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeEffect : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]

    private float fadet;
    public GameObject imagee;
    private Image image;
    Talking talking;

    void Start()
    {
        image = GetComponent<Image>();
        talking = GameObject.Find("dialog").GetComponent<Talking>();
    }

    // Update is called once per frame
    void Update()
    {
        if(talking.a>=1)
        {
            StartCoroutine(FadeOut(1,0));
        }

        if (image.color.a <= 0)
            imagee.SetActive(false);
    }

    private IEnumerator FadeOut(float start, float end)
    {
        float currentT = 0.0f;
        float percent = 0.0f;

        while(percent<1)
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
