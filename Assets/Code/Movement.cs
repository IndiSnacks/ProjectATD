using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    //Vector2 holding the input values
    private Vector2 inputVector = new Vector2(0,0);
    private Rigidbody2D rb;
    public float playerSpeed = 50f;
    private float moveSpeed;
    private float crouchSpeed;
    public Camera cam;
    Vector2 mousePos; 
    public bool crouchBool;


    public void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = playerSpeed;
        crouchSpeed = playerSpeed * 0.3333f;
    }

    private void move(InputAction.CallbackContext moveValue)
    {
        inputVector = moveValue.ReadValue<Vector2>();
    } 

    public void Update() 
    {
        Mouse mouse = Mouse.current;
        mousePos = cam.ScreenToWorldPoint(mouse.position.ReadValue());
    }

    private void FixedUpdate() 
    {
        //Moveing on plane
        rb.MovePosition(rb.position + inputVector * moveSpeed * Time.fixedDeltaTime);

        if(crouchBool == true)
        {
          moveSpeed =  crouchSpeed;
        }
        else
        {
            moveSpeed = playerSpeed;
        }
        
        //Mouse 
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;      
    }

    private void Crouch(InputAction.CallbackContext croucheValue)
    {
        crouchBool = croucheValue.ReadValueAsButton();
    }
    
    
}
