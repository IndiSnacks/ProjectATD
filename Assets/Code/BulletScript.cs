using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
	private GameObject bullet; 
	
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Destroy(bullet);
    }
}
