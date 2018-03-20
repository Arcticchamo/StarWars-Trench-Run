using UnityEngine;
using System.Collections;

public class BombCollision : MonoBehaviour {

	void OnTriggerEnter(Collider _Col)
	{
		if (_Col.gameObject.tag == "EBullet" || _Col.gameObject.tag == "Enemy") 
		{
			GameStates.instance.SetPlayerScore(100); 
			Destroy (_Col.gameObject); 
		}
	}

	void OnBecameInvisible()
	{
		Destroy (gameObject); 
	}
}
