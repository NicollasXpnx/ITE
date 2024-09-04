using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spaceship : MonoBehaviour
{
    public Projectile projectilePrefab;
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        ApplyMovement();
        FireProjectile();

    }
    void FireProjectile()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }

    void ApplyMovement()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");


        transform.Translate(Time.deltaTime * new Vector3(horizontal * speed, vertical * speed));
    }
}
