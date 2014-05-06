using UnityEngine;
using System.Collections;

public class FadeText : MonoBehaviour
{
	const float DURATION = 10.0f;
	private void Update() 
	{
		if( Time.time > DURATION)
		{
			Destroy(gameObject);
		}
		Color newColor = guiText.material.color;
		float proportion = (Time.time / DURATION);
		newColor.a = Mathf.Lerp(1, 0, proportion);
		guiText.material.color = newColor;
	}
}

