using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Follow : MonoBehaviour 
{

	float mass = 1.0f;
	float maxSpeed = 50.0f;
	Vector3 velocity;
	Vector3 force;
	int currentWaypoint = 0;


	Vector3 Seek(Vector3 point)
	{
		Vector3 desired = point - transform.position;
		desired.Normalize();
		desired *= maxSpeed;
		return desired - velocity;
	}


		// Use this for initialization
	void Start () 
	{
		renderer.material.color = Color.black;
	}
	
	// Update is called once per frame
	void Update ()
	{	
			Vector3 acceleration = force / mass; 
			velocity += acceleration * Time.deltaTime;
		    transform.position = transform.position + velocity * Time.deltaTime;	
	}
}
