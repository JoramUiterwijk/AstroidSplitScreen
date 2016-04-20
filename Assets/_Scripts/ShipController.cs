using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShipController : MonoBehaviour 
{
	private float speed = 30f;
	private float xTilt =1f;
	private float zTilt =0.2f;
	public float zMin, zMax;
	private Rigidbody rigidBody;

	void Awake()
	{
		rigidBody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (x, 0f, z);

		rigidBody.velocity = movement * speed;
		rigidBody.rotation = Quaternion.Euler(rigidBody.velocity.z * zTilt,0.0f,rigidBody.velocity.x * -xTilt);
	}
}

