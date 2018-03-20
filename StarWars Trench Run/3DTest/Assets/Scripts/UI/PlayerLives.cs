using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class PlayerLives : MonoBehaviour {

	private int m_Health = 3; 
	public PlayerCollision m_PlayerCollision;
	private Text m_text;

	void Start()
	{
		m_text = GetComponent<Text> ();
		m_PlayerCollision.PlayerLostLife += LifeLost; 
		m_text.text = "  Lives: " + m_Health.ToString ();
	}

	void Update()
	{
		m_text.text = "  Lives: " + m_Health.ToString ();
		if (m_Health <= 0) {
			Application.LoadLevel("GameOver");
		}
	}

	void LifeLost()
	{
		m_Health--; 
		m_text.text = "  Lives: " + m_Health.ToString ();
	}

	public void IncreaseLives(int _Lives)
	{
		m_Health += _Lives;
	}
}
