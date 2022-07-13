using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMove : MonoBehaviour
{

    Vector3 destination = new Vector3(-6.5f, -3.835135f, 0);

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, 0.01f);
    }

}
