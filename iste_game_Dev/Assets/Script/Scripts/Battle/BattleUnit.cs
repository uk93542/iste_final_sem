using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] ZombieBase _base;
    [SerializeField] int level;
    [SerializeField] bool isPlayerUnit;

    public Zombie Zombie { get; set; }
    public PlayerCharacter Player { get; set; }

    public void SetupZombie()
    {
        Zombie = new Zombie(_base, level);
        if (isPlayerUnit)
        {
            GetComponent<Image>().sprite = Zombie.Base.BackSprite;
        }
        else
        {
            GetComponent<Image>().sprite = Zombie.Base.FrontSprite;
        }
    }

    public void SetupPlayer(PlayerCharacter playerCharacter)
    {
        Player = playerCharacter;

    }
}
