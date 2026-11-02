using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    private Health PlayerHealth;
    public TextMeshProUGUI HealthText;

    private void Start()
    {
        PlayerHealth = GameObject.FindWithTag("Player").GetComponent<Health>();

        HealthText.text = PlayerHealth.CurrentHealth.ToString();
    }

    public void UpdateHealthUI()
    {
        HealthText.text = PlayerHealth.CurrentHealth.ToString();
    }

}
