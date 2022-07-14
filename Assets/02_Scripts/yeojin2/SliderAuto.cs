using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderAuto : MonoBehaviour
{
    [SerializeField] 
    private Vector3 distance = Vector3.up * 135.0f;

    private Transform targetTransform;
    private RectTransform rectTransform;


    public void Setup(Transform target)
    {
        targetTransform = target;
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if(targetTransform==null)
        {
            //Destroy(gameObject);
            return;
        }

        Vector3 tempPosition = targetTransform.localPosition;
        tempPosition.x -= 8.8f;
        tempPosition.y -= 5;

        Vector3 screenpos = Camera.main.WorldToScreenPoint(tempPosition);
        rectTransform.localPosition = screenpos + distance;
        transform.SetAsFirstSibling();
    }
}
