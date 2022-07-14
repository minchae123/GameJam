using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{
    public GameObject esc;
    private int escMenu = 0;
    Height hheight;

    private void Start()
    {
        hheight = GetComponent<Height>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (escMenu % 2 == 0)
            {
                esc.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                esc.SetActive(false);
                Time.timeScale = 1;
            }
            escMenu++;
            //escMenu.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            hheight.height -= 10;
        }
    }


}
