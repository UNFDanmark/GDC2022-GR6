using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    Rigidbody rb;
    float horizontalMovement;
    float verticalMovement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        MovementHandler(); 
    }

    void MovementHandler()
    {
        Vector3 moveVector = new(horizontalMovement * movementSpeed, rb.velocity.y, verticalMovement * movementSpeed);
        rb.velocity = moveVector;
    }

    void GetInput()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
    }
}
