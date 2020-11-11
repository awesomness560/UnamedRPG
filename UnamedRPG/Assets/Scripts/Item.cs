using MyBox;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public string name;
    public GameObject prefab;
    public Transform location;
    public Rarity rarity;
    public Type type;
    [ConditionalField("type", false, Type.Melee)] public bool OverrideMeleeAnimation;
    [ConditionalField("OverrideMeleeAnimation")] public Animation MeleeAnimation;
    [ConditionalField("type", false, Type.Armor)] public bool OverrideMovementAnimation;
    [ConditionalField("OverrideMovementAnimation")] public Animation MovementAnimation;


    public enum Rarity
    {
        Common,
        Rare,
        Epic,
        Mystical
    }

    public enum Type
    {
        Melee,
        Armor,
        Other
    }
}
