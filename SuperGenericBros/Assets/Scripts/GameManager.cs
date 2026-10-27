using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Health PlayerHealth;
    public PlayerRespawnHandler PRH;

    public GameState GameCurrentState = GameState.Running;
    void Start()
    {
        PRH.StartCoroutine("StartGame");
        PlayerHealth.HealthUI.UpdateHealthUI(PlayerHealth.MaxHealth);
    }

    
    void Update()
    {
        if (PlayerHealth.CurrentHealth <= 0)
        {
            PRH.StartCoroutine("PlayerDeath");
        }


    }
}

public enum GameState
{
    Running,Stopped
}