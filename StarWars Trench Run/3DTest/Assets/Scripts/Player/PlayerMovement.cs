using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    float m_Speed = 120f;
    float m_DirectionX;
    float m_RotationZ;
    Vector3 m_Movement;
	Transform m_transform; 
	float m_XPos;
	Renderer m_Render; 

	void Start()
	{
		m_transform = GetComponent<Transform> ();
		m_XPos = (-Screen.height / 2) / 2;
		m_XPos = (m_XPos + (m_XPos / 2));
		m_transform.position = new Vector3 (m_XPos, 0.0f, 0.0f); 
	}

    void Update()
    {
		//m_DirectionX = 0;
		m_RotationZ = 0;
		m_transform.position = new Vector3 (m_XPos, 0f, m_transform.position.z); 
		m_transform.rotation = Quaternion.Euler (0f, 90f, 0f); 

		
		if (Input.GetKey (KeyCode.UpArrow)) {
			m_DirectionX = -1f; 
			m_RotationZ = 5f; 
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			m_DirectionX = 1f;
			m_RotationZ = -5f; 
		}

		if (m_transform.position.z > (((Screen.height / 2) / 2) - 22)) 
		{
			m_DirectionX = 1f;
		} 
		else if (-m_transform.position.z > (((Screen.height / 2) / 2) - 22)) 
		{
			m_DirectionX = -1f;
		}

		m_Movement = new Vector3 (m_DirectionX, 0f, 0f);
		m_transform.Translate (m_Movement * m_Speed * Time.deltaTime);
		m_transform.Rotate (0f, 0f, m_RotationZ);


	}

	public void SetDirection(float _XPos)
	{
		m_DirectionX = _XPos;
	}
}