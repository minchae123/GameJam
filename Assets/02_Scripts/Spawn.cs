using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject land;
    Vector2 pos;

    private void Start()
    {
        InvokeRepeating("SpawnItem", 1f, 1f);    
    }

    private void Update()
    {
        
        
    }

    public void SpawnItem()
    {
        Debug.Log("asd");
/*        int r = Random.Range(1, 2);

        switch (r)
        {
            case 1:
                pos = new Vector2(0 , -4.5f);
                break;
            case 2:*/
                pos = new Vector2(20f, -4.5f);
/*                break;
        }*/

        Instantiate(land, pos, Quaternion.identity);
    }
}
