using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickone : MonoBehaviour
{
    public GameObject click;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click.SetActive(false);
        }
    }
}
