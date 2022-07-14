using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipButton : MonoBehaviour
{
    Talking talking;
    public GameObject skipbutton;

    void Start()
    {
        talking = GameObject.Find("dialog").GetComponent<Talking>();
        skipbutton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (talking.a >= 1)
            skipbutton.SetActive(false);
    }
}
