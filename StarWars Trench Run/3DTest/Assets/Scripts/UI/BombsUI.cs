using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class BombsUI : MonoBehaviour {

	private int m_Bombs = 3;
	private Text m_text;
	
	void Start()
	{
		m_text = GetComponent<Text> ();
		m_text.text = "  Bombs: " + m_Bombs.ToString ();
	}

	void Update()
	{
		m_text.text = "  Bombs: " + m_Bombs.ToString ();
	}
	
	public void BombUsed(int _bomb)
	{
		m_Bombs -= _bomb; 
	}

	public void IncreaseBombs(int _Bombs)
	{
		m_Bombs += _Bombs;
	}
	public int GetBombs()
	{
		return m_Bombs;
	}

}
