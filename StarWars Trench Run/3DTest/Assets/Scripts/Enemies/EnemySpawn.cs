using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawn : MonoBehaviour {

	public GameObject m_TieInterceptor; 
    public GameObject m_TieFighter;
    public GameObject m_TieAdvanced;
    private int m_WaitTime; 
	private int m_Random;


    void Start()
    {
        StartCoroutine(SpawnEnemy()); 
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            m_WaitTime = Random.Range(1, 3);
            yield return new WaitForSeconds(m_WaitTime);
                NextEnemySpawned();
        }
    }

	void NextEnemySpawned()
	{
		m_Random = Random.Range(1, 11); //Finds a number between 0 and 11
		if(m_Random > 0 && m_Random < 6) // 1 -> 5
		{
			Instantiate(m_TieFighter, new Vector3((transform.position.x - 300.0f), 0f, Random.Range((((Screen.height/2)/2)/2), (((-Screen.height/2)/2)/2))), Quaternion.identity); //Enemy 1
		}
		else if (m_Random > 5 && m_Random < 10) //6 -> 9
		{
			Instantiate(m_TieInterceptor, new Vector3(transform.position.x, 0f, Random.Range((((Screen.height/2)/2)/2), (((-Screen.height/2)/2)/2))), Quaternion.identity); //Enemy2 
		}
		else if(m_Random > 9) //10+
		{
			Instantiate(m_TieAdvanced, new Vector3(transform.position.x, 0.0f, 0.0f), Quaternion.Euler(0.0f, -90.0f, 0.0f));//Enemy3
			Instantiate(m_TieFighter, new Vector3((transform.position.x - 300.0f), 0.0f, 30.0f), Quaternion.identity); //Enemy 1
			Instantiate(m_TieFighter, new Vector3((transform.position.x - 300.0f), 0.0f, -60.0f), Quaternion.identity); //Enemy 1
		}
	}
}