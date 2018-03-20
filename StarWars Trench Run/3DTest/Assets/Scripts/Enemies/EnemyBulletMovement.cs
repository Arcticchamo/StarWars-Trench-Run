using UnityEngine;
using System.Collections;

public class EnemyBulletMovement : MonoBehaviour
{
    public float m_Speed;

	void Update () 
    {
		transform.Translate (transform.right * m_Speed * Time.deltaTime); 
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
