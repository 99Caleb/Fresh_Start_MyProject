using UnityEngine;
using UnityEngine.UI;

public class PlayerUserInterfaceManager: MonoBehaviour
{
    public PlayerHealthManager playerHealth;
    //public Image _heart1, _heart2, _heart3;
    public Image[] hearts;

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {

            hearts[i].color = i < playerHealth.lives ? new Color(1, 1, 1) : new Color(0, 0, 0, 0.25f);
        }
        
    }
}