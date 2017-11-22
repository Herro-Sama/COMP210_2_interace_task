using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(new Vector3( 0.0f, Mathf.Sin (Time.deltaTime),0.0f));
		print (Mathf.Sin (Time.deltaTime));
	}
}
