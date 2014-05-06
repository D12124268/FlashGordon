using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour 
{
	public GameObject CameraToControl;
	public GameObject ScreenText;
	//public bool cameraOn = false;

	// Use this for initialization
	void Start () 
	{
		//cameraOn = false;
		//Camera.main.gameObject.active = false;
	}

	void OnTriggerEnter( Collider WhatEnteredTheTrigger )
	{
		//Camera.main.gameObject.active = false;
		if( WhatEnteredTheTrigger.tag == "Player" )
		{
			//Camera.main.gameObject.active = false;
			CameraToControl.active = true;
			ScreenText.active = true;
			//GameObject.Find("Switchboard").GetComponent("CameraSwitcher").
			//SwitchCamera(1);
		}
	}
	
	/*void OnTriggerExit( Collider WhatExitedTheTrigger )
	{
		if( WhatExitedTheTrigger.tag == "Player" )
			CameraToControl.active = false;
	}
*/
}
