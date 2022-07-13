using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] GameObject obtacle;

    private void Start()
    {
        StartCoroutine("SpawnOb");
    }
    IEnumerator SpawnOb()
    {
        while (true)
        {
            Debug.Log("방해 생성");
            float r = Random.Range(0f, 10f);
            Vector3 pos = new Vector3(10.36f, -3.7f, 0);
            Instantiate(obtacle, pos, Quaternion.identity);
            yield return new WaitForSeconds(r);
        }
    }
}
