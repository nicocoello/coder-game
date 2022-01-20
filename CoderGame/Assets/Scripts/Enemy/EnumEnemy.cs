using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumEnemy : MonoBehaviour
{
    [SerializeField]private TestEnemy1 _enemy1;
    [SerializeField]private TestEnemy2 _enemy2;
    private enum EnemyType
    {
        Enemy1,
        Enemy2
    }
    [SerializeField] EnemyType enemyType;
    
    void Update()
    {
        ChooseEnemy(enemyType);
    }
    private void ChooseEnemy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Enemy1:
                _enemy1.LookAtPlayer();
                break;
            case EnemyType.Enemy2:
                _enemy2.MoveTowards();
                break;
            default:
                _enemy1.LookAtPlayer();
                break;
        }
    }
    
   
}
