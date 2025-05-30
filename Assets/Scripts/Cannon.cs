using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject projectilePrefab; // Assign this in the Inspector
    public Transform firePoint; // A child empty GameObject for positioning the shot
    public float projectileSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Fire when Space is pressed
        {
            Fire();
        }
    }

    void Fire()
    {

        if (projectilePrefab == null || firePoint == null)
        {
            Debug.LogError("ProjectilePrefab or FirePoint is not assigned!");
            return;
        }


        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        projectile.transform.rotation = Quaternion.Euler(0, 0, 45);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            float angle = 32f * Mathf.Deg2Rad;    // Convert to radians
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));    // Unit vector
            //rb.velocity = firePoint.right * projectileSpeed;
            rb.velocity = direction * projectileSpeed;


            Debug.Log("Projectile fired at 45 degrees: " + rb.velocity);
        }
    }

}
