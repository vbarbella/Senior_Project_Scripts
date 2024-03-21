using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Movement : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;

    public bool isRight = true;
    public float speed = 0.3f;
    private Vector3 pointAPosition;
    private Vector3 pointBPosition;

    void Start()
    {
        pointAPosition = new Vector3(0, pointA.position.y, 0);
        pointBPosition = new Vector3(0, pointB.position.y, 0);

    }

    void Update()
    {
        Vector3 thisPosition = new Vector3(0, transform.position.y, 0);
        if (isRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed);
        }    
    }
}
