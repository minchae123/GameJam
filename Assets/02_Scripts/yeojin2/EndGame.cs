using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("jonjal", 0);
        PlayerPrefs.SetInt("normal", 0);
        PlayerPrefs.SetInt("otaku", 0);
    }
}
