using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Unity.UI;
using UnityEngine.UI;

public class Fight : MonoBehaviour
{
    public Slider AIhp;
    public Slider Playerhp;
    [SerializeField] public int hpPlayer = 100;
    [SerializeField] private int hpAI = 100;
    [SerializeField] private int Heal = 30;

    public void Attack()
    {
        hpAI -= 10;
        hpAI = Mathf.Clamp(hpAI,0,100);
        AIhp.value = hpAI;
    }

    public void Health()
    { 
        hpPlayer += Heal;
        Playerhp.value = hpPlayer;
    }
}
