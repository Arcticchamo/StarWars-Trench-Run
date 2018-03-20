using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {

    public float m_Speed;
    public float m_BackgroundSize;

    private Vector3 m_StartingPos;

    void Start()
    {
        m_StartingPos = transform.position;
    }

    void Update()
    {
        float m_NewPos = Mathf.Repeat(Time.time * m_Speed, m_BackgroundSize);
        transform.position = m_StartingPos + Vector3.left * m_NewPos;
    }
}
