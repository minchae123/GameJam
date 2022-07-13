using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class height : MonoBehaviour
{
    public float Height  = 75.0f;
    public Text heighttext;

    // Update is called once per frame
    void Update()
    {
        Height -= Time.deltaTime *0.1f;
        heighttext.text = "¸ö¹«°Ô : " + Height.ToString("F2");
    }
}
