using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMove : MonoBehaviour
{
    float moveSpeed = 6f;

    private void Update()
    {
        transform.position -= moveSpeed * Time.deltaTime * Vector3.right;
    }
}
