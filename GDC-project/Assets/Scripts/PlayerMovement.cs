using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    Rigidbody rigidbody;
    float horizontalMovement;
    float verticalMovement;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
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
        Vector3 moveVector = new(horizontalMovement * movementSpeed, rigidbody.velocity.y, verticalMovement * movementSpeed);
        rigidbody.velocity = moveVector;
    }

    void GetInput()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
    }
}
