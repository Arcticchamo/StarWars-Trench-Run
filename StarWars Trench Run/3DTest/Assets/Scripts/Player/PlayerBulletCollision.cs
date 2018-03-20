using UnityEngine;
using System.Collections;

public class PlayerBulletCollision : MonoBehaviour {

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Enemy")
        {
			GameStates.instance.SetPlayerScore(100); 
            Destroy(gameObject);
        }
    }
}
