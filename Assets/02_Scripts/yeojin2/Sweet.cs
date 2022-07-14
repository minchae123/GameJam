using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweet : MonoBehaviour
{
    Height heightt;
/*    static AudioSource audioSource;
    public static AudioClip touchSo;*/

    private void Start()
    {
        heightt = GameObject.Find("Manager").GetComponent<Height>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("tru");
            heightt.height += 1.5f;
            Destroy(gameObject);
        }
    }

/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("tru");
            SoundPlay();
            heightt.height += 1.5f;
            Destroy(gameObject);
        }
    }*/

   
}
