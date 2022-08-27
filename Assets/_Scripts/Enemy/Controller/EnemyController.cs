using UnityEngine;

public enum EnemyStates
{
    Chase,
    Died,
    Attacking,
    
}
public class EnemyController : MonoBehaviour
{
    [Header("Entity")]
    [SerializeField]
    private Enemy enemy;
    
    [Header("Target")]
    [SerializeField] private Transform player;
    private EnemyStates actualState = EnemyStates.Chase;
   
    public void Update()
    {
        switch (actualState)
        {
            case EnemyStates.Chase:
            {
                if (enemy.IsInAttackRange(player))
                {
                    enemy.Attack();
                    actualState = EnemyStates.Attacking;
                }
                else
                {
                    enemy.Walk(player.position);
                }
               
                break;
            }
            case EnemyStates.Died:
            {
                
                break;
            }
            case EnemyStates.Attacking:
            {
                
                break;
            }
        }
    }
}