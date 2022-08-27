using System;
using UnityEngine;
using UnityEngine.UI;


public class HealthSystem : MonoBehaviour
{
    public event Action OnLifeZero;
    
    [SerializeField] float totalLife;
    [SerializeField] Image healthBar;

    private float currentLife;

    private void Start()
    {
        currentLife = totalLife;
    }

    public void Damage(float damage)
    {
        currentLife -= damage;
        
        if (currentLife <= 0)
        {
            OnLifeZero?.Invoke();
        }
        
        healthBar.fillAmount = currentLife / totalLife;
       
    }
}