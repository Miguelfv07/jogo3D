using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public float velocidadeRotacao = 10f;
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
        

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A))
        {
          
            animator.SetBool("Andar", true);
        }
     
        else
        {
            animator.SetBool("Andar", false);
        }
        float moveInput = Input.GetAxis("Horizontal");
        float moveInputZ = Input.GetAxis("Vertical");

        if (rb.velocity.magnitude > 0)
        {

            Vector3 direcao = new Vector3(moveInput, 0, moveInputZ).normalized;

            Quaternion novaRotacao = Quaternion.LookRotation(direcao);

            transform.rotation = Quaternion.Slerp(transform.rotation, novaRotacao, velocidadeRotacao * Time.deltaTime);
        }


        rb.velocity = new Vector3(moveInput * speed, rb.velocity.y, moveInputZ * speed);

       // rb.velocity = new Vector3(moveInput * speed, rb.velocity.y);



    }

  
}

