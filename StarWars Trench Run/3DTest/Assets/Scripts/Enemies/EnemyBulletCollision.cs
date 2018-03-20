using UnityEngine;
using System.Collections;

public class EnemyBulletCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "PBullet")
        {
            Destroy(Col.gameObject);
            Destroy(gameObject);
        }
    }
}
