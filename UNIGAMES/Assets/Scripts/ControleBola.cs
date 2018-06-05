using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ControleBola : MonoBehaviour
{

    public float speed;
    private Vector3 moveDirection;
    private Rigidbody rb;
    private bool jump;
    public float jumpPower = 1f;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        moveDirection = new Vector3(moveHorizontal, 0.0f, moveVertical);
        jump = Input.GetButton("Jump");
    }
    void FixedUpdate()
    {
        Move();
        Jump();
    }
    void Move()
    {
        rb.AddForce(moveDirection * speed);
    }
    void Jump()
    {
        isGrounded = Physics.Raycast(transform.position,Vector3.down,1f);
        if (jump && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}