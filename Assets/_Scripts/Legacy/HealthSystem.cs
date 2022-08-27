using UnityEngine;
using UnityEngine.UI;


public class HealthSystem : MonoBehaviour
{
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

        healthBar.fillAmount = currentLife / totalLife;
    }
}