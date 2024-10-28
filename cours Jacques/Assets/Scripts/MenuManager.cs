using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameManager m_gameManager;

    public void ClickOnPlay()
    {
        m_gameManager.ChangeGameState(GameManager.GameState.game);
    }

    public void ClickOnPause()
    {
        m_gameManager.ChangeGameState(GameManager.GameState.menu);
    }
}
