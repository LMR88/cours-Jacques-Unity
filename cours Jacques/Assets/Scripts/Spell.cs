using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Spell : ScriptableObject
{
    public string spellName;
    public int degats;
    public element spellElement;

    public enum element
    {
        water , fire
    }
}