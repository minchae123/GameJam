using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public GameObject explain;
    public GameObject tjfaud;
    public GameObject end;

    public void ExitGame()
    {
        Debug.Log("끝");
        Application.Quit();
    }

    public void GoStart()
    {
        Debug.Log("처음으로");
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
    public void tjfaudd()
    {
        tjfaud.SetActive(true);
    }
    public void endpn()
    {
        end.SetActive(true);
    }
    public void endpnEs()
    {
        end.SetActive(false);
    }
    public void tjfaudesc()
    {
        tjfaud.SetActive(false);
    }
    public void ExplainEsc()
    {
        explain.SetActive(false);
    }

}
