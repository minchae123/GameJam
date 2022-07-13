using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMove : MonoBehaviour
{
<<<<<<< HEAD
    public float x;
    Vector3 destination;

    private void Awake()
    {
        destination = new Vector3(x, -3.835135f, 0);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, 0.03f);

=======

    Vector3 destination = new Vector3(-6.5f, -3.835135f, 0);

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, 0.01f);
>>>>>>> main
    }

}
