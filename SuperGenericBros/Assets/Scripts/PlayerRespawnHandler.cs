using System.Collections;
using UnityEngine;

public class PlayerRespawnHandler : MonoBehaviour
{
    public PlayerController PlayerMovement;
    public GameManager GM;

    public GameObject GameOverScreen;
    public GameObject WinScreen;

    public GameObject HealthDisplay;

    public IEnumerator PlayerDeath()
    {
        PlayerMovement.enabled = false;
        GM.GameCurrentState = GameState.Stopped;

        GameOverScreen.SetActive(true);
        HealthDisplay.SetActive(false);
        WinScreen.SetActive(false);

        Time.timeScale = 0f;
        yield return null;
    }
    public IEnumerator Win()
    {
        PlayerMovement.enabled = false;
        GM.GameCurrentState = GameState.Stopped;

        GameOverScreen.SetActive(false);
        HealthDisplay.SetActive(false);
        WinScreen.SetActive(true);

        Time.timeScale = 0f;
        yield return null;
    }
    public IEnumerator StartGame()
    {
        PlayerMovement.enabled = true;
        GM.GameCurrentState = GameState.Running;

        GameOverScreen.SetActive(false);
        WinScreen.SetActive(false);

        HealthDisplay.SetActive(true);
        Time.timeScale = 1.0f;
        yield return null;
    }
}
