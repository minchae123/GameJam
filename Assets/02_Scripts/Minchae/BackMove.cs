using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMove : MonoBehaviour
{
    float moveSpeed = 4f;

    private void Update()
    {
        transform.position -= moveSpeed * Time.deltaTime * Vector3.right;
    }
}
