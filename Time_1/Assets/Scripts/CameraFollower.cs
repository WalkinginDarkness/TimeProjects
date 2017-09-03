using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {


	public GameObject follower;
	private Vector3 offset;
	private Vector3 targetPosition;

	// Use this for initialization
	void Awake () 
	{

		offset = transform.position - follower.transform.position;

	}

	// Update is called once per frame
	void Update () {



	}

	private void FixedUpdate()
	{
		targetPosition = follower.transform.position + offset;
		transform.position = Vector3.Lerp(transform.position, targetPosition/*new Vector3(targetPosition.x, transform.position.y, targetPosition.z)*/, 0.1f);
	}
}