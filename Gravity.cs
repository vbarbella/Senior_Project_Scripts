using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public static float newGrav = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d.gravityScale = newGrav;
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.gravityScale = newGrav;
    }
}
