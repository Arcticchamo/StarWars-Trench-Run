using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	private bool m_Pause = false; 

	public void PauseGame()
	{
		if (!m_Pause) 
		{
			Time.timeScale = 0;
			m_Pause = true; 
		} 
		else if (m_Pause) 
		{
			Time.timeScale = 1; 
			m_Pause = false; 
		}
	}
}
