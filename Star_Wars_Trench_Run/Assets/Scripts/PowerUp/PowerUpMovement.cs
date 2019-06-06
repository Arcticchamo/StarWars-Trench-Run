using UnityEngine;
using System;

public class PowerUpMovement : MonoBehaviour {

	private int m_Health = 5; //health of each power up
	private PowerUpSpawner m_Spawner; //Spawner
	private PlayerBulletSpawn m_BulletSpawn; //Player
	private PlayerLives m_lives; //Lives
	private BombsUI m_Bomb; //Bombs

	void Start()
	{
		m_Spawner = GameObject.FindGameObjectWithTag("PowerUp").GetComponent<PowerUpSpawner> ();
		m_BulletSpawn = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBulletSpawn> (); 
		m_lives = GameObject.FindGameObjectWithTag ("UI").GetComponentInChildren<PlayerLives> ();
		m_Bomb = GameObject.FindGameObjectWithTag ("UI").GetComponentInChildren<BombsUI> ();
	}

	void Update()
	{
		transform.Rotate (0f, 1f, 0f); //Slowly rotate them
	}

	void OnTriggerEnter(Collider _Col)
	{
		if (_Col.gameObject.tag == "EBullet" || _Col.gameObject.tag == "Enemy")
		{
			m_Health -= 1;
			if (m_Health <= 0) 
			{
				m_Spawner.SetSpawned(false);
				Destroy(gameObject); 
			}
		}

		else if (_Col.gameObject.tag == "PBullet") 
		{
			m_Health -= 2; 
			if (m_Health <= 0) 
			{
				m_Spawner.SetSpawned(false);
				//Object type check
				if (gameObject.tag == "SpeedUp")
				{
					m_BulletSpawn.SetQuadFire(true); 
				}
				else if (gameObject.tag == "SpeedDown")
				{
					m_BulletSpawn.SetQuadFire(false); 
				}
				else if (gameObject.tag == "Bomb")
				{
					m_Bomb.IncreaseBombs(1);
				}
				else if (gameObject.tag == "Health")
				{
					m_lives.IncreaseLives(1);
				}
				Destroy(gameObject); 
			}
		}
	}
}
