using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] PlayerCharacter playerCharacter;
    [SerializeField] BattleHUD playerHud;

    private void Start()
    {
        SetupBattle();
    }

    public void SetupBattle()
    {
        // Setup Player
        playerHud.SetData(playerCharacter);
        
        // Setup Zombie (We'll add this later!)
    }
}
