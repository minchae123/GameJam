using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderAuto : MonoBehaviour
{
    [SerializeField] 
    private Vector3 distance = Vector3.down * 35.0f;

    private Transform targetTransform;
    private RectTransform rectTransform;


    public void Setup(Transform target)
    {
        targetTransform = target;
        rectTransform = GetComponent<RectTransform>();
    }

    private void LateUpdate()
    {
        if(targetTransform==null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 screenpos = Camera.main.WorldToScreenPoint(targetTransform.position);
        rectTransform.position = screenpos + distance;
    }
}