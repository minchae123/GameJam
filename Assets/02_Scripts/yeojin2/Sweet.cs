using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweet : MonoBehaviour
{
    Height heightt;

    private void Start()
    {
        heightt = GameObject.Find("Manager").GetComponent<Height>();
    }

/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("tt");
            Heightt.Height += 2;
            Destroy(gameObject);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("tru");
            heightt.height += 2;
            Destroy(gameObject);
        }
    }
}
