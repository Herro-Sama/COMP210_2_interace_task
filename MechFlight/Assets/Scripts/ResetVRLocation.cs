using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetVRLocation : MonoBehaviour {


	public GameObject Spawn;

	// Use this for initialization
	void Start () 
	{
		gameObject.transform.SetPositionAndRotation (Spawn.transform.position, Spawn.transform.rotation);
	}

}
