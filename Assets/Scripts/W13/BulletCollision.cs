using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles bullet collision logic, including audio playback and destruction behavior upon impact.
/// </summary>
public class BulletCollision : MonoBehaviour
{
    /// <summary>
    /// Audio source used to play the collision sound effect.
    /// </summary>
    [SerializeField] private AudioSource source;

    /// <summary>
    /// Audio clip to play when the bullet collides with a wall or enemy.
    /// </summary>
    [SerializeField] private AudioClip clip;

    /// <summary>
    /// Initializes the audio source by locating the main camera and assigning the collision sound clip.
    /// </summary>
    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        source.clip = clip;
    }

    /// <summary>
    /// Detects collisions with objects tagged "Wall" or "Enemy", triggers sound, and destroys the bullet.
    /// </summary>
    /// <param name="collision">The collider that was hit.</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall") || collision.CompareTag("Enemy"))
        {
            // TODO: Spawn particles here

            source.Play(); // Play collision sound
            Destroy(gameObject); // Destroy bullet
        }
    }
}