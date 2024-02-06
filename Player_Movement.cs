using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public int playerSpeed = 10;
	private float moveX;
    
    void Update () {
		PlayerMove ();
	}

    void PlayerMove () {
		//CONTROLS
		moveX = Input.GetAxis("Horizontal");

		//PHYSICS
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}
}
