using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public TextMeshProUGUI HealthText;

    public void UpdateHealthUI(int health)
    {
        HealthText.text = health.ToString();
    }

}
