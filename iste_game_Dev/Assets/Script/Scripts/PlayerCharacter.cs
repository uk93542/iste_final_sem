using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] string characterName = "Hero";
    [SerializeField] int level = 1;

    [Header("Base Stats")]
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    [Header("Moves")]
    [SerializeField] List<LearnableMove> learnableMoves;

    public int CurrentHp { get; set; }
    public List<Move> Moves { get; set; }

    private void Start()
    {
        CurrentHp = maxHp;
        Moves = new List<Move>();
        foreach (var move in learnableMoves)
        {
            if (move.Level <= level)
            {
                Moves.Add(new Move(move.Base));
            }
            if (Moves.Count >= 4)
            {
                break;
            }
        }
    }

    public string Name { get { return characterName; } }
    public int Level { get { return level; } }
    public int MaxHp { get { return maxHp; } }
    public int Attack { get { return attack; } }
    public int Defense { get { return defense; } }
    public int SpAttack { get { return spAttack; } }
    public int SpDefense { get { return spDefense; } }
    public int Speed { get { return speed; } }
}
