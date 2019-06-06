using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour{

	public Action PlayerLostLife = null; 

	void OnTriggerEnter(Collider _Col) 
	{
		if (_Col.gameObject.tag == "Enemy" || 
		    _Col.gameObject.tag == "EBullet") 
		{
			if (PlayerLostLife != null)
				PlayerLostLife();
		}
	}
}