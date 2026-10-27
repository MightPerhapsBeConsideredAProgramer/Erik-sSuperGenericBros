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
        if (PlayerHealth.CurrentHealth <= 0 && GameCurrentState == GameState.Running)
        {
            PRH.StartCoroutine("PlayerDeath");
        }

        if (GameCurrentState == GameState.Won)
        {
            PRH.StartCoroutine("Win");
        }
    }
}

public enum GameState
{
    Running,Stopped,Won
}