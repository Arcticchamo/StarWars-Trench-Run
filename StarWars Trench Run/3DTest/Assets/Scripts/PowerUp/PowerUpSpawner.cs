using UnityEngine;
using System.Collections;

public class PowerUpSpawner : MonoBehaviour {

	public GameObject m_HealthUp;
	public GameObject m_SpeedDown;
	public GameObject m_SpeedUp;
	public GameObject m_BombUp; 
	public int m_MaxTimer; 
	private bool m_Spawned = false; 
	private int m_Timer = 0; 
	private int m_RandomPowerUp;
	
	void Update()
	{
		if (m_Timer == m_MaxTimer)
			SpawnPowerUp(); 

		m_Timer++; 
	}

	void SpawnPowerUp()
	{
		if (m_Spawned == false) 
		{
			m_RandomPowerUp = Random.Range (1, 5);
			switch (m_RandomPowerUp) {
			case 1:
				Instantiate (m_SpeedDown, new Vector3 (0f, 0f, 0f) , Quaternion.identity); 
				break;
			case 2: 
				Instantiate (m_HealthUp, new Vector3 (0f, 0f, 0f), Quaternion.identity); 
				break;
			case 3:
				Instantiate (m_SpeedUp, new Vector3 (0f, 0f, 0f), Quaternion.identity); 
				break;
			case 4:
				Instantiate (m_BombUp, new Vector3 (0f, 0f, 0f), Quaternion.identity); 
				break; 
			default:
				Debug.LogError ("Error, No PowerUp Selected"); 
				break; 
			}
			TimerRandomise ();
		}
		else 
			m_Timer = 0; 
	}

	void TimerRandomise()
	{
		m_MaxTimer = Random.Range(300, 701); //From 300 to 700  
		m_Timer = 0; 
	}

  	public void SetSpawned(bool _Spawned)
	{
		m_Spawned = _Spawned; 
		m_Timer = 0;
	}
}





