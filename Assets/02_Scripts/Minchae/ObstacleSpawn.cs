using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] GameObject obtacle;

    private void Update()
    {
        
    }

    IEnumerator SpawnOb()
    {
        float r = Random.Range(1.2f, 2.4f);
        Vector3 pos = new Vector3(10.36f, -3.7f, 0);
        Instantiate(obtacle, pos, Quaternion.identity);
        yield return new WaitForSeconds(r);
    }
}
