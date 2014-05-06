using UnityEngine;
using System.Collections;

public class SmoothCameraRotate : MonoBehaviour
 {
	public Transform target;
	public float damping = 6.0f;
	public bool smooth = true;
	public float rotation;

		
	void  LateUpdate ()
	{

		if (target) 
		{
			if (smooth)
			{
				// Look at and dampen the rotation
				//rotation = Quaternion.LookRotation(target.position - transform.position);
				//transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
			}
			else
			{
				// Just lookat
				transform.LookAt(target);
			}
		}
	}
	
	void  Start ()
	{
		// Make the rigid body not change rotation
		if (rigidbody)
			rigidbody.freezeRotation = true;
	}
}

