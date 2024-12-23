using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class AI : FigthManager
{
     public int healthPlayer = 100;
     public int attackAI = 10;
     private int HealAI = 30;

     public int damages = 10;
    public enum AIState
    {
        loosing,
        winning, 
    }

    public AIState m_currentAIState = AIState.winning;
        
    public void DetermineState(int hp)
    {
        m_currentAIState = hp < 10 ? AIState.loosing : AIState.winning;
    }
        
    public void ManageAITurn()
    {
        DetermineState(FigthManager.instance.hpAI);
        switch (m_currentAIState )
        {
            case AIState.loosing:ManageLoosing(); break;
            case AIState.winning: ManageWinning(); break;
            default: throw new ArgumentOutOfRangeException();
        } 
        EndTurn();
    }

    public void ManageLoosing()
    {
        var rand = Random.Range(0, 100);
        if (rand> 85)
        {
            RunAway();
            return;
        } 
        
        if(rand > 70)
        {
            Heal();
            return;
        }
     
        Attack();
    }

    public void Attack()
    {
        runtimeData.hp -= attackAI ;
        runtimeData.hp = Mathf.Clamp(healthPlayer, 0, 100);
        Playerhp.value = FigthManager.instance.runtimeData.hp;
    }
    
    public void Heal()
    {
        FigthManager.instance.hpAI += HealAI;
    }
    
    public void RunAway()
    {
        // IA QUITS FIGHT
    }
    
    public void ManageWinning()
    {
        var rand = Random.Range(0, 100);
        if (rand > 20)
        {
            Attack();
            return;
        } 
        
        if(rand > 10)
        {
            Heal();
            return;
        }
    }

    public void EndTurn()
    {
        FigthManager.instance.ChangeGameState(FigthManager.GameState.Player);
    }
    
        
}
