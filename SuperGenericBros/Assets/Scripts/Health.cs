using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    public SpriteRenderer PlayerSprite;
    public float InvonrabilityDuration;

    private float InvonrabilityTime;

    public HealthUI HealthUI;

    public GameObject DamageIndicator;

    private void Update()
    {
        if (InvonrabilityTime >= Time.time)
            DamageIndicator.SetActive(true);

        if (InvonrabilityTime < Time.time)
            DamageIndicator.SetActive(false);
    }


    public void TakeDamage(int damage)
    {
        if (InvonrabilityTime >= Time.time)
            return;
        



        InvonrabilityTime = Time.time + InvonrabilityDuration;


        if (damage <= 0) return;

        SetHealth(CurrentHealth - damage);
    }



    public void SetHealth(int Value)
    {
        if (Value >= MaxHealth) return;

        CurrentHealth = Value;

        HealthUI.UpdateHealthUI(CurrentHealth);
    }
}
