using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
   [field : Header("Player health"), SerializeField]
   public int hp { get; private set; }
   
   [field : Header("Player armor"), Space, SerializeField]
   public int armor { get; private set; }
   
   [field : Header("Player speed"), Space, SerializeField]
   public int speed { get; private set; }
   
   [field : Header("Player spell"), Space, SerializeField]
   public Spell spell { get; private set; }
   
   [field : Header("Player spell 2"), Space, SerializeField]
   public Spell spell2 { get; private set; }
   
   public PlayerDataInstance Instance()
   {
      return new PlayerDataInstance(this);
   }

}

public class PlayerDataInstance
{
   public int hp;
   public int armor;
   public int speed;

   public PlayerDataInstance(PlayerData data)
   {
      hp = data.hp;
      armor = data.hp;
      speed = data.hp;
   }
}

