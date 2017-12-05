using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	private float Health = 50;



	void OnTriggerEnter (Collider BulletCollider) 
	{
		if (BulletCollider.name == "Bullet(Clone)")
		{
			if (Health <= 0)
			{
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
