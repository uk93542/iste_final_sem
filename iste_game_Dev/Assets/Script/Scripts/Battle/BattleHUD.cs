using UnityEngine;
using UnityEngine.UI;
public class BattleHUD : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] Text hpText;
    [SerializeField] HPBar hpBar;

    public void SetData(PlayerCharacter player)
    {
        nameText.text = player.Name;
        levelText.text = player.Level.ToString();
        hpText.text = player.CurrentHp + "/" + player.MaxHp;
        hpBar.SetHP((float)player.CurrentHp / player.MaxHp);
    }
}
