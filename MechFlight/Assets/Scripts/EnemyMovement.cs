using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float Amplitude;
	public float VerticalSpeed;

	private Vector3 MovingPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		gameObject.transform.Translate(new Vector3( 0.0f, Mathf.Sin (Time.timeSinceLevelLoad * VerticalSpeed) * Amplitude,0.0f));
	}

}
