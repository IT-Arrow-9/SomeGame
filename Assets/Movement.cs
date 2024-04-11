using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public float doubleJumpForce = 7f;
    public float sprintSpeed = 10f;
    public float sprintJumpForce = 12f;
    public float sprintDashForce = 20f;
    public float rotationSpeed = 5f;

    private Rigidbody rb;
    private bool isGrounded = true;
    private bool isSprinting = false;
    private bool doubleJumped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (Input.GetButtonDown("Jump") && (isGrounded || !doubleJumped))
        {
            if (!isGrounded)
            {
                doubleJumped = true;
                rb.AddForce(Vector3.up * doubleJumpForce, ForceMode.Impulse);
            }
            else
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }

            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprinting = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded)
        {
            rb.AddForce(transform.forward * sprintDashForce, ForceMode.Impulse);
        }

        if (isSprinting)
        {
            movement = movement.normalized * sprintSpeed * Time.deltaTime;
            rb.MovePosition(transform.position + movement);
        }
        else
        {
            movement = movement.normalized * speed * Time.deltaTime;
            rb.MovePosition(transform.position + movement);
        }

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * mouseX * rotationSpeed);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
            doubleJumped = false;
        }
    }
}
