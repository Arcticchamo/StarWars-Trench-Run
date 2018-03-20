using UnityEngine;
using System.Collections;

public class PlayerBulletSpawn : MonoBehaviour
{
    private int m_Timer = 0;
	public AudioClip m_Audioclip;
	private AudioSource m_Source; 
    public GameObject m_Bullet;
	private Transform m_BulletSpawn1;
	private Transform m_BulletSpawn2;
	private Transform m_BulletSpawn3;
	private Transform m_BulletSpawn4;
	private bool m_QuadFire = false;

    void Start()
    {
		m_BulletSpawn1 = transform.FindChild("BulletFirePoint1");
		m_BulletSpawn2 = transform.FindChild("BulletFirePoint2");
		m_BulletSpawn3 = transform.FindChild("BulletFirePoint3");
		m_BulletSpawn4 = transform.FindChild("BulletFirePoint4");
		m_Source = GetComponent<AudioSource> (); 
    }

    void Update()
    {
        if (m_Timer == 25)
        {
            Instantiate(m_Bullet, m_BulletSpawn1.position, Quaternion.Euler(0f, 0f, -90f));
			PlaySound();
        }

		if (m_QuadFire) {
			if (m_Timer == 12) {
				Instantiate (m_Bullet, m_BulletSpawn4.position, Quaternion.Euler (0f, 0f, -90f));
				PlaySound ();
			}

			if (m_Timer == 37) {
				Instantiate (m_Bullet, m_BulletSpawn3.position, Quaternion.Euler (0f, 0f, -90f));
				PlaySound ();
			}
		}
        if (m_Timer == 50)
        { 
            Instantiate(m_Bullet, m_BulletSpawn2.position, Quaternion.Euler(0f, 0f, -90f));
			PlaySound();
            m_Timer = 0; 
        }

        m_Timer++;
    }

	public void SetQuadFire(bool _FireRate)
	{
		m_QuadFire = _FireRate;
	}
	public bool GetQuadFire()
	{
		return m_QuadFire; 
	}

	void PlaySound()
	{
		m_Source.PlayOneShot(m_Audioclip);
		m_Source.Play();
	}
}
