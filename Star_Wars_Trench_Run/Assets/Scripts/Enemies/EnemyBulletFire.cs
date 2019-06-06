using UnityEngine;
using System.Collections;

public class EnemyBulletFire : MonoBehaviour
{
    public GameObject m_Bullet;
    private int m_BulletSpawnTime;
    public int m_MaxTimer = 100; 
    private Transform m_EnemyBulletSpawnPoint;

    void Start()
    {
        m_EnemyBulletSpawnPoint = transform.Find("EnemyBulletSpawn");
    }

    void Update()
    {
        if (m_BulletSpawnTime == m_MaxTimer)
        {
            Instantiate(m_Bullet, m_EnemyBulletSpawnPoint.position, Quaternion.Euler(0f, 0f, 90f));
            m_BulletSpawnTime = 0;
        }
        m_BulletSpawnTime++;
    }

}
