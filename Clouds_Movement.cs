using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds_Movement : MonoBehaviour
{
    public Transform pointC;
    public Transform pointD;

    public bool isRight = true;
    public float speed = 0.3f;
    private Vector3 pointCPosition;
    private Vector3 pointDPosition;

    void Start()
    {
        pointCPosition = new Vector3(pointC.position.x, 0, 0);
        pointDPosition = new Vector3(pointD.position.x, 0, 0);

    }

    void Update()
    {
        Vector3 thisPosition = new Vector3(0, transform.position.y, 0);
        if (isRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointD.position, speed);
        }  
    }
}
