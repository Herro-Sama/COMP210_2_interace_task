using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintJoystickInputs : MonoBehaviour {

	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;

	public GameObject ammoType;
	public GameObject barrelLPosition;
	public GameObject barrelRPosition;

	private Vector3 MovementDirection; 
	private Vector3 RotationDirection;
		
	void Update() 
	{
		MovementDirection.z = Input.GetAxis("VerticalJoy1") * speed;
		MovementDirection.x = Input.GetAxis("HorizontalJoy1") * speed;
		MovementDirection *= Time.deltaTime;
			

		RotationDirection.x = Input.GetAxis("VerticalJoy2") * rotationSpeed;
		RotationDirection.y = Input.GetAxis("HorizontalJoy2") * rotationSpeed;
		RotationDirection *= Time.deltaTime;

		//print("Vertical Joystick One " + Input.GetAxis("VerticalJoy1"));
		//print("Horizontal Joystick One " + Input.GetAxis("HorizontalJoy1"));

		//print("Fire Joystick One " + Input.GetAxis("Fire"));
		//print("Boost Joystick One " + Input.GetAxis("Boost"));

		//print("Vertical Joystick Two " + Input.GetAxis("VerticalJoy2"));
		//print("Horizontal Joystick Two " + Input.GetAxis("HorizontalJoy2"));

		//print (MovementDirection);

		if (Input.GetAxis ("Fire") > 0)
		{
			Instantiate (ammoType, barrelLPosition.transform.position, barrelLPosition.transform.rotation);
			Instantiate (ammoType, barrelRPosition.transform.position, barrelRPosition.transform.rotation);
		}

		gameObject.transform.Translate (MovementDirection);
		gameObject.transform.Rotate (RotationDirection);

	}

}
