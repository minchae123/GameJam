using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField] GameObject back1;
    [SerializeField] GameObject back2;

    private void Update()
    {
        if (back1.transform.position.x <= -19.22f )
        {
            back1.transform.Translate(37.2f , 0 ,0);
        }

        if (back2.transform.position.x <= -19.22f)
        {
            back2.transform.Translate(37.2f, 0, 0);
        }
    }
}
