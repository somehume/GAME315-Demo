using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float lifetime = 3f;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name); // Debug log to check collision

        if (collision.gameObject.CompareTag("Target")) // Check if it hit the square
        {
            Debug.Log("Projectile hit the target! Destroying the target.");
            Destroy(collision.gameObject); // Destroy the square target
        }
    }
}
