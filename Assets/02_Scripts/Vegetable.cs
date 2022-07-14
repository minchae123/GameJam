using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetable : MonoBehaviour
{
    [SerializeField] private AudioClip dieSound;
    Height heightt;
    private AudioSource audioSource;

    private void Start()
    {
        heightt = GameObject.Find("Manager").GetComponent<Height>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("god");
            heightt.height -= 1.5f;
            Destroy(gameObject);

            Instantiate(dieSound);
        }
    }
}
