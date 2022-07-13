using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] clouds;

    private void Start()
    {
        StartCoroutine("SpawnClouds");    
    }

    IEnumerator SpawnClouds()
    {
        while (true)
        {
            int r = Random.Range(0, 6);
            float x = Random.Range(11f, 15.1f);
            float y = Random.Range(1.2f, 6.2f);
            Vector3 pos = new Vector3(x, y, 0);
            Instantiate(clouds[r], pos, Quaternion.identity);

            float count = Random.Range(1.0f, 1.9f);
            yield return new WaitForSeconds(count);
        }
    }
}
