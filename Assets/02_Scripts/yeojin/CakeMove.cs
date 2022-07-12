using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMove : MonoBehaviour
{
    [SerializeField]
    private GameObject ClickText;

    [SerializeField]
    private GameObject ClickSlider;

    private bool Click;

    Vector3 destination = new Vector3(-6.5f, -3.835135f, 0);

    private void Awake()
    {
        ClickText = GameObject.FindGameObjectWithTag("ClickText");
        ClickSlider = GameObject.FindGameObjectWithTag("Clickslider");

        ClickText.SetActive(false);
        ClickSlider.SetActive(false);

        Click = false;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, 0.01f);

        if (transform.position.x <= -6.0f && !Click) 
        {
            StartCoroutine("CLICKTwink");
        }
    }

    private IEnumerator CLICKTwink()
    {
        while (true)
        {
            ClickSlider.SetActive(true);            
            ClickText.SetActive(true);
            yield return new WaitForSeconds(2.0f);
            ClickText.SetActive(false);

            Click = true;

            break;
        }
    }
}
