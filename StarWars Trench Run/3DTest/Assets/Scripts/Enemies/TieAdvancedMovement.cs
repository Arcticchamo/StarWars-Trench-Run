using UnityEngine;
using System.Collections;

public class TieAdvancedMovement : MonoBehaviour {

	public float m_Speed;
	
	void Update()
	{
		transform.position = new Vector3(transform.position.x, 0f, transform.position.z); 
		transform.Translate (transform.right * m_Speed * Time.deltaTime); 
	}
	
	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
	
	void OnTriggerEnter(Collider Col)
	{
		if (Col.gameObject.tag == "PBullet" || Col.gameObject.tag == "Player") 
		{
			Destroy(gameObject);
		}
	}
}
