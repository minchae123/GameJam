using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Height: MonoBehaviour
{
    public float height  = 75.0f;
    public Text heighttxt;

    void Update()
    {
        height -= Time.deltaTime *0.1f;
        heighttxt.text = "¸ö¹«°Ô : " + height.ToString("F2") + "kg";
    }
}
