using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] public GameObject game;
    [SerializeField] public GameObject menu;

    public enum GameState
    {
        menu,
        game
    }

    public GameState m_currentGameState = GameState.menu;
    
    public void ChangeGameState(GameState newGameState)
    {
        switch (m_currentGameState)
        {
            case GameState.menu:DisableMenu(); break;
            case GameState.game:DisableGame(); break;
        }
        m_currentGameState = newGameState;
        
        switch (newGameState)
        {
            case GameState.menu:SetUpMenu(); break;
            case GameState.game:SetUpGame(); break;
        }
    }

    public void DisableMenu()
    {
        menu.SetActive(false);
    }

    public void DisableGame()
    {
        game.SetActive(false);
    }

    public void SetUpGame()
    {
        game.SetActive(true);
    }

    public void SetUpMenu()
    {
        menu.SetActive(true);
    }
    
}
