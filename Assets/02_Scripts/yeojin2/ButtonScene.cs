using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonScene : MonoBehaviour
{
    public void SceneLoader(string a)
    {
        SceneManager.LoadScene(a);
    }
}
