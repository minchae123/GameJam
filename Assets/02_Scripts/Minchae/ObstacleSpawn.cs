using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] yummy;

    private void Start()
    {
        StartCoroutine("SpawnOb");
    }
    IEnumerator SpawnOb()
    {
        while (true)
        {
            float r = Random.Range(1f, 15f);
            int num = Random.Range(0, 9);
            Vector3 pos = new Vector3(10.36f, -3.7f, 0);
            Instantiate(yummy[num], pos, Quaternion.identity);
            yield return new WaitForSeconds(r);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
