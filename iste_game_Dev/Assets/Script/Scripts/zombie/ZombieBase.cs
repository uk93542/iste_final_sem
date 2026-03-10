using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "Zombie", menuName = "Zombie/Create new zombie")]

public class ZombieBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] ZombieType type1;
    [SerializeField] ZombieType type2;

    //base stats
    [SerializeField] int maxHp;
    [SerializeField] int maxMp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;

    public string Name {
        get {return name;}
    }

    public string Description {
        get {return description;}
    }

    public Sprite FrontSprite {
        get {return frontSprite;}
    }

    public Sprite BackSprite {
        get {return backSprite;}
    }

    public ZombieType Type1 {
        get {return type1;}
    }

    public ZombieType Type2 {
        get {return type2;}
    }

    public int MaxHp {
        get {return maxHp;}
    }

    public int Attack {
        get {return attack;}
    }

    public int Defense {
        get {return defense;}
    }

    public int SpAttack {
        get {return spAttack;}
    }

    public int SpDefense {
        get {return spDefense;}
    }

    public int Speed {
        get {return speed;}
    }

    public List<LearnableMove> LearnableMoves {
        get { return learnableMoves; }
    }
}

[System.Serializable]
public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase Base {
        get { return moveBase; }
    }

    public int Level {
        get { return level; }
    }
}

public enum ZombieType
{
    none,
    fatfuck,
    bball,
    sleepy

}