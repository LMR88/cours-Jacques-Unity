using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class AIData : ScriptableObject
{
    [field : Header("AI health"), SerializeField]
    public int hp { get; private set; }
   
    [field : Header("AI armor"), Space, SerializeField]
    public int armor { get; private set; }
   
    [field : Header("AI speed"), Space, SerializeField]
    public int speed { get; private set; }
   
    [field : Header("AI spell"), Space, SerializeField]
    public Spell spell { get; private set; }
    
    [field : Header("Player spell 2"), Space, SerializeField]
    public Spell spell2 { get; private set; }
    
   
    public AIDataInstance Instance()
    {
        return new AIDataInstance(this);
    }

}

public class AIDataInstance
{
    public int hp;
    public int armor;
    public int speed;

    public AIDataInstance(AIData data)
    {
        hp = data.hp;
        armor = data.hp;
        speed = data.hp;
    }
    
}