using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DropObjects : MonoBehaviour 
{
	public Transform spawnLocation;
	public List<GameObject> spawnPrefab = new List<GameObject>();
	private GameObject astroid;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.L)) 
		{
			SpawnAstroid ();
		}
	}

	public void SpawnAstroid()
	{
		if (spawnLocation == null	||spawnPrefab.Count==0) 
		{
			Debug.LogError("retard alert: SpawnerScript");
			return;
		}

		astroid = (GameObject) Instantiate (spawnPrefab[0], spawnLocation.position, Quaternion.identity);  
	}
}
