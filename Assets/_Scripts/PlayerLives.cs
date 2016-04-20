using UnityEngine;
using System.Collections;

public class PlayerLives : MonoBehaviour 
{
	private int lives;

	void Awake() 
	{
		lives = 3;
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Astroid")) 
		{
			lives -= 1;
			Destroy (other.gameObject);
		}
	}
}
