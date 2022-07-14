using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
public class KeyManager : MonoBehaviour
{
    public GameObject esc;
    private int escMenu = 0;
    Height hheight;
    [SerializeField] private Image image = null;

    private void Start()
    {
        Time.timeScale = 0;
        image.DOFade(0, 1.5f);
        Time.timeScale = 1;
        escMenu = 0;
        hheight = GetComponent<Height>();
    }
    private void Update()
    {
/*        if(image.color.a == 0)
        {
            Time.timeScale = 1;           
        }
*/
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
