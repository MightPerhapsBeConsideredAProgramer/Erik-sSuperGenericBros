using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Health PlayerHealth;

    public GameState GameCurrentState = GameState.Running;
    public bool IsPlayerAlive;
    void Start()
    {
        IsPlayerAlive = true;
        PlayerHealth.HealthUI.UpdateHealthUI(PlayerHealth.MaxHealth);
    }

    
    void Update()
    {
        if (PlayerHealth.CurrentHealth <= 0)
        {
            IsPlayerAlive = false;
        }
        if (!IsPlayerAlive)
        {
            Debug.Log("Player is dead");
            GameCurrentState = GameState.Stopped;
        }
    }
}

public enum GameState
{
    Running,Stopped
}