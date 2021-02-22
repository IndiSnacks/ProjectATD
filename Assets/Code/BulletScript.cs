using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Checks for collsion
public class BulletScript : MonoBehaviour
{	
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Destroy(GameObject);
    }
}
