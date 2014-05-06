﻿using UnityEngine;
using System.Collections;

public class CountdownTime : MonoBehaviour 
{
	
	public float Seconds = 59;
	public float Minutes = 1;
	
	
	void Update () 
	{
		if (Seconds <= 0)
		{
			Seconds = 59;
			if (Minutes >= 1)
			{
				Minutes --;
			}
			else
			{
				Minutes = 0;
				Seconds = 0;
				//GameObject.Find ("TimerText").guiText.text = Minutes.ToString ("f0") + ":0" + Seconds.ToString("f0");
				//PlayerPrefs.SetInt("newScore", newScore);
				Application.LoadLevel("Start");				
			}
		}
		else
		{
			Seconds -= Time.deltaTime;
			Application.Quit();
		}
	/*	if(Mathf.Round(Seconds) <= 9 ) 
		{
			GameObject.Find ("TimerText").guiText.text = Minutes.ToString ("f0") + ":0" + Seconds.ToString("f0");
		}
		else
		{
			GameObject.Find ("TimerText").guiText.text = Minutes.ToString ("f0") + ":" + Seconds.ToString("f0") ;
		}
		*/
	}
}