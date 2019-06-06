using UnityEngine;
using System.Collections;

public class GameStates : MonoBehaviour {

    private int m_Score = 0;

    public int GetPlayerScore()
    {
        return m_Score; 
    }
    public void SetPlayerScore(int _Point)
    {
		if (m_Score < 1000)
			_Point *= 1;
		else if (m_Score >= 1000 && m_Score < 10000)
			_Point *= 2;
		else if (m_Score >= 10000 && m_Score < 40000)
			_Point *= 4;
		else if (m_Score >= 40000)
			_Point *= 10;

		m_Score += _Point; 
    }

             //SINGLETON
    public static GameStates instance = null;
    void Awake()
    {
        if (instance != null)
            Debug.LogError("Instance Has Already Been Created Somewhere");

        instance = this;

		Debug.Log (Screen.width);
		Debug.Log (Screen.height);
    }
}
