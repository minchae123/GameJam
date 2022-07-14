using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetable : MonoBehaviour
{
    Height heightt;

    private void Start()
    {
        heightt = GameObject.Find("Manager").GetComponent<Height>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("god");
            heightt.height -= 1.5f;
            Destroy(gameObject);
        }
    }
}
