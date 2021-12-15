using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    bool jumpKeyWasPressed;
    float horizontalInput;
    float verticalInput;
    Rigidbody rigidbodyComponent;


    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

    }

    //FixedUpdate is called once every physics update
    void FixedUpdate()
    {
        if (jumpKeyWasPressed)
        {
            rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;

        }

        rigidbodyComponent.velocity = new Vector3(horizontalInput * 5, rigidbodyComponent.velocity.y, verticalInput * 5);
        rigidbodyComponent.velocity = new Vector3(horizontalInput * 5, rigidbodyComponent.velocity.y, verticalInput * 5);

    }
}
