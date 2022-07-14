using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorySentences : MonoBehaviour
{
    public string[] sentences;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Talking.instance.Ondialogue(sentences);
    }

}
