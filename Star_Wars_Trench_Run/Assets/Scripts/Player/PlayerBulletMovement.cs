using UnityEngine;
using System.Collections;

public class PlayerBulletMovement : MonoBehaviour
{
    public float m_Speed; 
	private Transform m_Transform; 

	void Start()
	{
		m_Transform = GetComponent<Transform> ();
	}

    void Update()
    {
		m_Transform.Translate (-m_Transform.right * m_Speed * Time.deltaTime); 
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
