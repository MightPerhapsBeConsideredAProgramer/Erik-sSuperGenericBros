using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;


    public void TakeDamage(int damage)
    {
        if (damage <= 0) return;

        SetHealth(CurrentHealth - damage);
    }



    public void SetHealth(int Value)
    {
        if (Value >= MaxHealth) return;

        CurrentHealth = Value;
    }
}
