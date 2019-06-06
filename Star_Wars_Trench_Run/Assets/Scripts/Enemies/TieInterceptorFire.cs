using UnityEngine;
using System.Collections;

public class TieInterceptorFire : MonoBehaviour {

	private int m_Timer = 0; 
	Transform m_BulletSpawn1;
	Transform m_BulletSpawn2;
	public GameObject m_Bullet;


	void Start()
	{
		m_BulletSpawn1 = transform.Find ("BulletSpawn1");
		m_BulletSpawn2 = transform.Find ("BulletSpawn2");
	}

	void Update()
	{
		if (m_Timer == 50)
		{
			Instantiate(m_Bullet, m_BulletSpawn1.position, Quaternion.Euler(0f, 0f, -90f));
		}
		
		if (m_Timer == 100)
		{ 
			Instantiate(m_Bullet, m_BulletSpawn2.position, Quaternion.Euler(0f, 0f, -90f));
			m_Timer = 0; 
		}
		
		m_Timer++;
	}
}
