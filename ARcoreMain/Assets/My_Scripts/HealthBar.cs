using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 100;

    private int currentHealth;
    public event  Action<float> OnHealtPctChanged = delegate { };
    private void OnEnable()
    {
        currentHealth = maxHealth;
    }
    public void ModifyHealth(int amount)
    {
        currentHealth += amount;
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealtPctChanged(currentHealthPct);
    }
    public void Damage()
    {
        ModifyHealth(-10);
    }
}
