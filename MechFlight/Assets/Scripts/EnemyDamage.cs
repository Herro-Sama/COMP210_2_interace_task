using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	private float Health = 50;

	public GameObject Explosion;

	void OnTriggerEnter (Collider BulletCollider) 
	{
		if (BulletCollider.name == "Bullet(Clone)")
		{
			if (Health <= 0)
			{
				
				Instantiate (Explosion, gameObject.transform.position, gameObject.transform.rotation);
				Destroy (gameObject);
			}

			else
			{
				Health--;
				Destroy(BulletCollider);
			}
		}
	}

}
