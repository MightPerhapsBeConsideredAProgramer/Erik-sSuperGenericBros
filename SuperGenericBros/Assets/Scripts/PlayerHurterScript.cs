using UnityEngine;
using UnityEngine.Events;

public class PlayerHurterScript : MonoBehaviour
{
    public UnityEvent UpdatePlayerHealthUI;

    private GameManager GM;

    public int Damage;
    public bool InstaKill = false;

    private void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        UpdatePlayerHealthUI.AddListener(GameObject.FindGameObjectWithTag("HealthUI").GetComponent<HealthUI>().UpdateHealthUI);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!InstaKill)
            {
                GM.PlayerHealth.TakeDamage(Damage);
                UpdatePlayerHealthUI.Invoke();
            }

            if (InstaKill)
                GM.PlayerHealth.SetHealth(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!InstaKill)
            {
                GM.PlayerHealth.TakeDamage(Damage);
                UpdatePlayerHealthUI.Invoke();
            }

            if (InstaKill)
                GM.PlayerHealth.SetHealth(0);
        }
    }
}
