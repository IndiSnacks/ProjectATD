using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    private bool shootbool;
    public Transform firepoint;
    public GameObject bulletPrefab;
    private float bulletForce = 200f;
    

    private void shootcheck(InputAction.CallbackContext shootValue)
    {
        shootbool = shootValue.ReadValueAsButton();
    }

    private void shoot()
    {
      GameObject Projectile = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
      Rigidbody2D rbp = Projectile.GetComponent<Rigidbody2D>();
      //rbp.AddForce(firepoint.right * bulletForce, ForceMode2D.Impulse);
      //Debug.Log("Shoot");
    }

    private void FixedUpdate() 
    {
        if(shootbool === true)
        {
            shoot();
        }
    }
}
