using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeTouch : MonoBehaviour
{
    [SerializeField]
    private int click = 1;
    private CakeClickHP cakeHP;

    private void Awake()
    {
        cakeHP = GetComponent<CakeClickHP>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
           
            if (rayHit.collider != null)
            {
                if (rayHit.collider.CompareTag("Cake"))
                {
                    cakeHP.Takedam(click);
                }
            }
        }
    }
}
