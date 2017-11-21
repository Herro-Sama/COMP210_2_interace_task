using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMotion : MonoBehaviour {

	void Fire ()
	{
		gameObject.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * 6;
		Destroy (gameObject, 2.0f);
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
