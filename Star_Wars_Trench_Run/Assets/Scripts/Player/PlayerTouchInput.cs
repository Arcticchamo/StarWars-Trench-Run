using UnityEngine;
using System.Collections;

public class PlayerTouchInput : MonoBehaviour
{
    public PlayerMovement m_Movement;
	public BombFire m_BombFire;
	public PauseMenu m_Pause; 
    Vector2 m_ScreenPoint;

	void Start()
	{
		m_BombFire = GetComponent<BombFire> ();
		m_Movement = GetComponent<PlayerMovement> ();
		m_Pause = GetComponent<PauseMenu> ();
	}

    void Update()
    {
        if (Input.touchCount > 0)
        {
			Touch m_touch = Input.GetTouch(0);
            m_ScreenPoint = Input.GetTouch(0).position;

            if (m_ScreenPoint.x > (Screen.width / 2))
            {
                if (Input.touchCount >= 2)
                {
					m_BombFire.SetBombFired(true);
                }
            }

            else if (m_ScreenPoint.x < (Screen.width / 2))
            {
				if (m_ScreenPoint.y <  (Screen.height / 2))
				{
					m_Movement.SetDirection(1);                  
				}
				else if (m_ScreenPoint.y >=  (Screen.height / 2))
				{
					m_Movement.SetDirection(-1); 
				}
            }
        }
        else if (Input.touchCount == 0)
        {
            m_Movement.SetDirection(0);
        }
    }

}
