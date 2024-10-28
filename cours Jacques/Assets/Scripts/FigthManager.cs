using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FigthManager : MonoBehaviour
{
    [SerializeField] private AI ia;
    public static FigthManager instance;
    [SerializeField] public GameObject Player;
    [SerializeField] public GameObject AI;
    public Slider AIhp;
    public Slider Playerhp;
    [SerializeField] public int hpPlayer = 100;
    [SerializeField] public int hpAI = 100;
    [SerializeField] private int Heal = 30;

    private void Start()
    {
        instance = this;
    }

    public enum GameState
    {
        AI,
        Player
    }

    public GameState m_currentGameState = GameState.AI;

    public void ChangeGameState(GameState newGameState)
    {
        
        switch (m_currentGameState)
        {
            case GameState.AI:
                DisableAI();
                break;
            case GameState.Player:
                DisablePlayer();
                break;
        }

        m_currentGameState = newGameState;

        switch (newGameState)
        {
            case GameState.AI:
                SetUpAI();
                break;
            case GameState.Player:
                SetUpPlayer();
                break;
        }
    }

    public void DisableAI()
    {
        AI.SetActive(false);
    }

    public void DisablePlayer()
    {
        Player.SetActive(false);
    }

    public void SetUpPlayer()
    {
        Player.SetActive(true);
    }

    public void SetUpAI()
    {
        AI.SetActive(true);
        ia.ManageAITurn();
    }
    
    public void Attack()
    {
        hpAI -= 10;
        hpAI = Mathf.Clamp(hpAI,0,100);
        AIhp.value = hpAI;
        ChangeGameState(GameState.AI);
    }

    public void Health()
    { 
        hpPlayer += Heal;
        hpPlayer = Mathf.Clamp(hpPlayer, 0, 100);
        Playerhp.value = hpPlayer;
        ChangeGameState(GameState.AI);
    }
}

