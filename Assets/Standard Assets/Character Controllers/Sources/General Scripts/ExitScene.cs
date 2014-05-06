using UnityEngine;
using System.Collections;

public class ExitScene : MonoBehaviour
{
		//public GameObject CameraToControl;
		//public GameObject ScreenText;

		void Start () 
		{
	
		}
		
		void OnTriggerEnter( Collider WhatEnteredTheTrigger )
		{

			if( WhatEnteredTheTrigger.tag == "Enemy" )
			{
			Application.LoadLevel("MingCity 2");	
			}
		}
		

}

