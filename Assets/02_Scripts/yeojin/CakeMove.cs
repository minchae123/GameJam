using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CakeMove : MonoBehaviour
{
    //float speed = 4f;
    public float x;
    public Transform ham;
    public float duration;
    public PathType pathType;
    public PathMode pathMode;

    public Vector3[] path;
    //Vector3 destination;
    private void Awake()
    {
        //destination = new Vector3(x, -3.835135f, 0);
    }
    private void Start()
    {
        ham.DOPath(path, duration, pathType, pathMode);
    }

    void Update()
    {
            //ham.DOPath(path, duration, pathType, pathMode);
            //transform.position += (Vector3)Vector2.left * speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, destination, 0.04f);
    }

}
