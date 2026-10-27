using UnityEngine;

public class WinpadScript : MonoBehaviour
{
    public GameManager GM;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GM.GameCurrentState = GameState.Won;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GM.GameCurrentState = GameState.Won;
        }
    }
}
