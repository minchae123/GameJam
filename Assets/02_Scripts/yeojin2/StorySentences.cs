using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorySentences : MonoBehaviour
{
    public string[] sentences;
    private Image image;
    public Image back;
    public Image DDong;
    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)&&image.color.a<=30)
            Talking.instance.Ondialogue(sentences);
    }

    public void Back()
    {
        back.gameObject.SetActive(true);
        DDong.gameObject.SetActive(true);
    }

}
