using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 0.0f;
    [SerializeField] private Vector3 dir = Vector3.zero;

    private void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    public void Moveto(Vector3 direction)
    {
        dir = direction;
    }
}
