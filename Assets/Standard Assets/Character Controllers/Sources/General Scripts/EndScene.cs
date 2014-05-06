using UnityEngine;
using System.Collections;

public class EndScene : MonoBehaviour
{
	//public GameObject CameraToControl;
	//public GameObject ScreenText;
	
	void Start () 
	{
		
	}
	
	void OnTriggerEnter( Collider WhatEnteredTheTrigger )
	{
		
		if( WhatEnteredTheTrigger.tag == "Player" )
		{
			Application.LoadLevel("EndScene");	
		}
	}
	
	
}

