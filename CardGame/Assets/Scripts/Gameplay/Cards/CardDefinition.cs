using System;
using System.Collections.Generic;

[Serializable]
public class CardDatabase
{
    public List<CardDefinition> cards;
}

[Serializable]
public class CardDefinition
{
    public string id;
    public string name;
    public string description;

    public string effect;
    public EffectConditions effect_conditions;
    public EffectApplication effect_application;
    public float effect_chance;

    public int health;
    public int damage;
    public int mana;

    public string summon_method;
    public SummonConditions summon_conditions;

    public List<string> tags;

    public string attack_type;
    public int level;
    public string image;

    public CardStats stats;
}

[Serializable]
public class EffectConditions
{
    // Later you can add:
    // public string targetType;
    // public int requiredAllyCount;
    // etc.
}

[Serializable]
public class EffectApplication
{
    // Later you can add:
    // public int buffAmount;
    // public string debuffType;
    // etc.
}

[Serializable]
public class SummonConditions
{
    // Later you can add:
    // public int requiredManaCrystals;
    // public bool needsSpecificTag;
    // etc.
}

[Serializable]
public class CardStats
{
    public int attack;
    public int defense;
    public int utility;
}
