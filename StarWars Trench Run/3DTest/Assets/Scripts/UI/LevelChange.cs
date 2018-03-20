using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {

    public string m_NextLevel;

	public void ChangeLevel()
	{
		if (m_NextLevel != "QuitGame") 
		{
			Application.LoadLevel (m_NextLevel);
		} 
		else if (m_NextLevel == "QuitGame") 
		{
			Application.Quit ();
		}
	}
}
