using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToCockpit : MonoBehaviour {

	public GameObject cockpitLocation;

	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.position = cockpitLocation.transform.position;
	}
}
