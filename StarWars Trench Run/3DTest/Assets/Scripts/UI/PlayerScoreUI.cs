using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class PlayerScoreUI : MonoBehaviour 
{
	private Text m_text;

	void Start()
	{
		m_text = GetComponent<Text> ();
		m_text.text = "Score: " + GameStates.instance.GetPlayerScore ().ToString ();
	}

	void Update()
	{
		m_text.text = "Score: " + GameStates.instance.GetPlayerScore ().ToString ();
	}

}
