using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletForce = 200f;

    public void shoot(InputAction.CallbackContext shootValue)
    {
        if(shootValue.started)
        {
            shooted();
        }
    }

    private void shooted()
    {
        GameObject Projectile = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rbp = Projectile.GetComponent<Rigidbody2D>();
        rbp.AddForce(firepoint.right * bulletForce, ForceMode2D.Impulse);
    }
}

