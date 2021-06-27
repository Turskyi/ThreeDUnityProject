using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private new Rigidbody rigidbody;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The game has start");

        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // controlling any dirrection
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector3(
            horizontalInput * movementSpeed,
            rigidbody.velocity.y,
            verticalInput * movementSpeed
            );

        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, jumpForce, 0);
        }

    }
}
