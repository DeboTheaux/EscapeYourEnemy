using UnityEngine;

public class EnemyView : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] Enemy enemy;
    private void Start()
    {
        enemy.OnAttack += AttackAnimation;
        enemy.OnDie += DieAnimation;
        enemy.OnWalk += WalkAnimation;
        enemy.OnTakeDamage += TakeDamageAnimation;
    }

    void AttackAnimation()
    {
        Debug.Log("Animacion de ataque");
    }
    void DieAnimation()
    {
        Debug.Log("Animacion de muerte");
 
    }
    void WalkAnimation()
    {
        Debug.Log("Animacion de caminata");

    }
    void TakeDamageAnimation()
    {
        Debug.Log("Animacion de recibir damage");

    }
}