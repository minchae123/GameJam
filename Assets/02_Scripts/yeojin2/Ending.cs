using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    int otakusave;
    int normalsave;
    int jonjalsave;

    public GameObject otakusilu;
    public GameObject jonjalsilu;
    public GameObject normalsilu;

    void Save()
    {
        otakusave = PlayerPrefs.GetInt("otaku");
        normalsave = PlayerPrefs.GetInt("normal");
        jonjalsave = PlayerPrefs.GetInt("jonjal");
    }

    void Start()
    {
        Save();

        otakusave = PlayerPrefs.GetInt("otaku");
        normalsave = PlayerPrefs.GetInt("normal");
        jonjalsave = PlayerPrefs.GetInt("jonjal");

        Debug.Log(jonjalsave);

        if (otakusave>=1)
        {
            otakusilu.SetActive(false);
        }

        if(normalsave>=1)
        {
            normalsilu.SetActive(false);
        }

        if(jonjalsave>=1)
        {
            jonjalsilu.SetActive(false);
        }

        
    }

    void Update()
    {
        
    }
}
