using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{

 public Transform traget;

 private void LateUpdate() 
 {
     if(traget != null)
     {
        transform.position = new Vector2( traget.position.x, traget.position.y);
     }
 }
}
