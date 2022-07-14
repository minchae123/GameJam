using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public GameObject explain;

    public void ExitGame()
    {
        Debug.Log("��");
        Application.Quit();
    }

    

    public void GoStart()
    {
        Debug.Log("ó������");
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Explain()
    {
        explain.SetActive(true);
    }

    public void ExplainEsc()
    {
        explain.SetActive(false);
    }

}
