using UnityEngine;

public class PlayerHurterScript : MonoBehaviour
{
    public GameManager GM;
    public int Damage;
    public bool InstaKill = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!InstaKill) 
                GM.PlayerHealth.TakeDamage(Damage);
            if (InstaKill)
                GM.PlayerHealth.SetHealth(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!InstaKill)
                GM.PlayerHealth.TakeDamage(Damage);
            if (InstaKill)
                GM.PlayerHealth.SetHealth(0);
        }
    }
}
