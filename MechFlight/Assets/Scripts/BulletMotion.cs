using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMotion : MonoBehaviour {

	void Start ()
	{
		gameObject.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * 26;
		Destroy (gameObject, 2.0f);
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
