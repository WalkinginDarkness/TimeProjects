using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {


	public float moveSpeed = 3.0f;
	public float gravity = 9.81f;
	//private CharacterController myController;


	void Start () {
		
	}
	

	void FixedUpdate () {

		//Vector3 movementZ = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;
		Vector3 movementX = Input.GetAxis("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;
		// Convert combined Vector3 from local space to world space based on the position of the current gameobject (player)
		//Vector3 movement = transform.TransformDirection(movementZ+movementX);
		//movement.y -= gravity * Time.deltaTime;

		transform.Translate (movementX);
	}
}


	