using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    float HorizontalMove = 0f;

    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;

    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed",Mathf.Abs (HorizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetTrigger("Jump");
            
        }
        
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }   else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        animator.SetFloat("VerticalSpeed", controller.m_Rigidbody2D.velocity.y);
        animator.SetBool("IsGround", controller.m_Grounded);
    }



   

    void FixedUpdate()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }


}
