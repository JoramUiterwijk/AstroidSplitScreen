using UnityEngine;
using System.Collections;

public class Aim : MonoBehaviour
{
	private float speed = 15;
	private Rigidbody rigidBody;

	void Awake()
	{
		rigidBody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.U)) 
		{
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.J)) 
		{
			transform.Translate (Vector3.down * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.H)) 
		{
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.K)) 
		{
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}
	}
}