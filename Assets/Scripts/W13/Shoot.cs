using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles player shooting logic, instantiating bullets toward the mouse pointer and playing a sound effect.
/// </summary>
public class Shoot : MonoBehaviour
{
    /// <summary>
    /// Prefab of the bullet to instantiate.
    /// </summary>
    [SerializeField] private GameObject bulletPrefab;

    /// <summary>
    /// Speed at which the bullet travels.
    /// </summary>
    [SerializeField] private float bulletSpeed = 1f;

    /// <summary>
    /// AudioSource component for playing the shooting sound.
    /// </summary>
    [SerializeField] private AudioSource source;

    /// <summary>
    /// AudioClip played when the player shoots.
    /// </summary>
    [SerializeField] private AudioClip audioClip;

    /// <summary>
    /// Assigns the shooting AudioClip to the AudioSource.
    /// </summary>
    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = audioClip;
    }

    /// <summary>
    /// Detects left mouse click and triggers bullet firing and sound playback.
    /// </summary>
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
            source.Play();
        }
    }

    /// <summary>
    /// Fires a bullet toward the mouse pointer by instantiating and propelling it with velocity.
    /// </summary>
    private void Fire()
    {
        Vector2 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 playerPosition = new(transform.position.x, transform.position.y);
        Vector2 direction = (target - playerPosition).normalized;

        GameObject projectile = Instantiate(bulletPrefab, playerPosition, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}