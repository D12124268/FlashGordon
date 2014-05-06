using UnityEngine;
using System.Collections;

public class PlanetExplode : MonoBehaviour
{
		public GameObject ScreenEffect;
		
		// Use this for initialization
		void Start () 
		{

		}
		
		void OnTriggerEnter( Collider WhatEnteredTheTrigger )
		{
			if( WhatEnteredTheTrigger.tag == "Player" )
			{

				ScreenEffect.active = true;

				
			}
		}

}

