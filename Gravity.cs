using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public static float newGrav = 0.1f;

    void Start()
    {
        rb2d.gravityScale = newGrav;
    }

    void Update()
    {
        rb2d.gravityScale = newGrav;
    }
}
