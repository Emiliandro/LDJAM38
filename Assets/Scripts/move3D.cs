using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move3D : MonoBehaviour 
{

	public float speed = 1f;
	private float movex = 0, movey = 0;
	public Rigidbody source;

	void FixedUpdate () {
		movex = Input.GetAxis("Horizontal");
		movey = Input.GetAxis("Vertical");
		source.velocity = new Vector2(movex * speed, movey * speed);
	}
}
