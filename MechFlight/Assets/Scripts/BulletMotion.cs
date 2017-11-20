using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMotion : MonoBehaviour {

	private Vector3 BulletSpeed;

	void awake ()
	{
		//BulletSpeed.forward
	}

	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.Translate (BulletSpeed);
	}
}
