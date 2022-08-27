using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/Enemy", order = 1)]
public class EnemyData_SO : ScriptableObject
{
    [Header("Movement")]
    public float speed;
    public float rotationSpeed;
    [Header("Attack")]
    public float attackRange;
    public float attackDamage;
    
}
