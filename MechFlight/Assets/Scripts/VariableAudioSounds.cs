using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAudioSounds : MonoBehaviour {

	private float delayTimer;
	private float resetTimer = 3;

	// Use this for initialization
	void Start () 
	{
		delayTimer = Random.Range (1, 10);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		delayTimer -= Time.deltaTime;

		if (delayTimer <= 0)
		{
			GetComponent<AudioSource> ().enabled = true;
			resetTimer -= Time.deltaTime;

			if (resetTimer <= 0)
			{
				resetTimer = 3;
				delayTimer = Random.Range (1, 10);
				GetComponent<AudioSource> ().enabled = false;
			}

		}




	}
}
