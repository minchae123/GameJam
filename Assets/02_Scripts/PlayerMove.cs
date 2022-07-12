using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int mvSpeed = 5;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * mvSpeed * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * mvSpeed * Time.deltaTime;

        transform.Translate(x, y, 0);
    }
}
