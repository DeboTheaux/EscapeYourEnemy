using System;
using UnityEngine;
using UnityEngine.AI;

public class Enemy:MonoBehaviour
{
    [SerializeField] private NavMeshAgent nmAgent;
    [SerializeField] private EnemyData_SO data;

    public event Action OnTakeDamage;
    public event Action OnAttack;
    public event Action OnDie;
    public event Action OnWalk;
    void Start()
    {
        nmAgent.speed = data.speed;
        nmAgent.angularSpeed = data.rotationSpeed;
    }


    public void TakeDamage(float damage)
    {
        OnTakeDamage?.Invoke();
    }

    public void Walk(Vector3 destinyPosition)
    {
        nmAgent.destination = destinyPosition;
        OnWalk?.Invoke();
    }

    public void Attack()
    {
        nmAgent.ResetPath();
        OnAttack?.Invoke();
    }

    void Die()
    {
        OnDie?.Invoke();
    }

    public bool IsInAttackRange(Transform target)
    {
        var distance = (transform.position - target.position).magnitude;
        
        if (distance > data.attackRange)
        {
            return false;
        }

        return true;
    }
}