using UnityEngine;
using System.Collections;

public class BombFire : MonoBehaviour {

	public BombsUI m_bombUI;
	public GameObject m_Bomb;
	public AudioClip m_Countdown; 
	public AudioClip m_LaserFire;

	private int m_Timer = 0; 
	private AudioSource m_AudioSource;
	private bool m_BombFired = false; 
	private Vector3 m_BombPos;
	
	[SerializeField]
	private int m_MaxTimer = 200; 

	void Start()
	{
		m_bombUI.GetComponent<BombsUI> ();
		m_AudioSource = GetComponent<AudioSource> ();
		m_BombPos = new Vector3((0 - Screen.height * 3), 0.0f, 0.0f);
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.B) && !m_BombFired) 
		{
			if (m_bombUI.GetBombs() >= 0)
			{
			m_BombFired = true; 
			SoundCountdown();
			}
		}
		if (m_BombFired) 
		{
			m_Timer++; 	
		}

		if (m_Timer >= m_MaxTimer)
		{
			Instantiate(m_Bomb, m_BombPos, Quaternion.Euler (0.0f, 0.0f , 90.0f));
			SoundLaserFire();
			m_Timer = 0;
			m_BombFired = false; 
			m_bombUI.BombUsed(1);
		}
	}

	void SoundCountdown()
	{
		m_AudioSource.PlayOneShot (m_Countdown, 30f);
		m_AudioSource.Play();
	}
	void SoundLaserFire()
	{
		m_AudioSource.PlayOneShot (m_LaserFire, 17f);
	}

	public void SetBombFired(bool _Firing)
	{
		if (!m_BombFired) 
		{
			if (m_bombUI.GetBombs() > 0)
			{
				m_BombFired = _Firing;
				SoundCountdown ();
			}
		}
	}
}
