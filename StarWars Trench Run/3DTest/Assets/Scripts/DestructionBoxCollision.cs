using UnityEngine;
using System.Collections;

public class DestructionBoxCollision : MonoBehaviour {

    void OnTriggerEnter(Collider _Col)
    {
		if (_Col.gameObject.tag != "Player") 
		{
			if (_Col.gameObject.tag == "Enemy")
				GameStates.instance.SetPlayerScore (-100);

			Destroy (_Col.gameObject); 
		}
	}
}
