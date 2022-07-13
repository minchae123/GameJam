using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CakeManager : MonoBehaviour
{
    public Slider hpSlider;
    public GameObject clickTxt;

    public GameObject sslider;

    private void Start()
    {
        sslider.SetActive(false);    
    }
}
