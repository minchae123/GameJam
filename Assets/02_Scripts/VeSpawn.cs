using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] vege;

    private void Start()
    {
        StartCoroutine("SpawnOb");
    }
    IEnumerator SpawnOb()
    {
        while (true)
        {
            float r = Random.Range(1f, 15f);
            float y = Random.Range(-3.5f, 0.3f);
            int num = Random.Range(0, 7);
            Vector3 pos = new Vector3(10.35f, y, 0);
            Instantiate(vege[num], pos, Quaternion.identity);
            yield return new WaitForSeconds(r);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
