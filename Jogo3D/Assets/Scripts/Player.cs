using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour

{
    public float speed = 5;
    public int jumpForce = 10;
    private Rigidbody rb;
    [SerializeField] Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
       
    }
    void Move()
    {

        if (Input.GetKey(KeyCode.D))
        {
          
            animator.SetBool("Andar", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
          
            animator.SetBool("Andar", true);
        }

        else
        {
            animator.SetBool("Andar", false);
        }
        float moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(moveInput * speed, rb.velocity.y);

        rb.velocity = new Vector3(moveInput * speed, rb.velocity.y);



    }

  
}

