using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCombat : MonoBehaviour
{
    public EnemyManager enemyManager; // Reference to the EnemyManager

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Press "1" to attack Goblin
        {
            enemyManager.AttackEnemy("Goblin", 20);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) // Press "2" to attack Orc
        {
            enemyManager.AttackEnemy("Orc", 30);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) // Press "3" to attack Dragon
        {
            enemyManager.AttackEnemy("Dragon", 50);
        }
    }
}