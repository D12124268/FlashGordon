using UnityEngine;
using System.Collections;

public class RotateUp : MonoBehaviour {

	public float RotationSpeed = 1f;
	
	void Update () 
	{
		transform.RotateAround(transform.up, RotationSpeed * Time.deltaTime);
	}
}
