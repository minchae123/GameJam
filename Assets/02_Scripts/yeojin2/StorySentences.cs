using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorySentences : MonoBehaviour
{
    public string[] sentences;

    private void OnMouseDown()
    {
        Talking.instance.Ondialogue(sentences);
    }
}
