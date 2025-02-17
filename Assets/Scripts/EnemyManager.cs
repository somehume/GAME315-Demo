using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Dictionary to store enemy health (Key: Enemy Name, Value: Health Points)
    Dictionary<string, int> enemyHealth = new Dictionary<string, int>();

    void Start()
    {
        // Initialize enemy health
        enemyHealth["Goblin"] = 100;
        enemyHealth["Orc"] = 150;
        enemyHealth["Dragon"] = 300;

        Debug.Log("Enemies Initialized.");
        DisplayEnemyHealth();
    }

    // Function to attack an enemy
    public void AttackEnemy(string enemyName, int damage)
    {
        if (enemyHealth.ContainsKey(enemyName))
        {
            enemyHealth[enemyName] -= damage; // Reduce health by damage amount

            if (enemyHealth[enemyName] <= 0)
            {
                Debug.Log(enemyName + " has been defeated!");
                enemyHealth.Remove(enemyName); // Remove enemy from dictionary
            }
            else
            {
                Debug.Log(enemyName + " took " + damage + " damage. Remaining HP: " + enemyHealth[enemyName]);
            }
        }
        else
        {
            Debug.Log("Enemy " + enemyName + " does not exist!");
        }
    }

    // Function to display current health of all enemies
    void DisplayEnemyHealth()
    {
        foreach (KeyValuePair<string, int> enemy in enemyHealth)
        {
            Debug.Log(enemy.Key + " HP: " + enemy.Value);
        }
    }
}