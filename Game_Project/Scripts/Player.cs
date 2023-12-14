using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotationSpeed = 7f;
    [SerializeField] private float jumpSpeed = 4f;

    private bool isWalking;
    private bool isJumping;

    // private bool isIdle = true;

    private CharacterController characterController;
    private float ySpeed;
    private float originalStepOffset;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        originalStepOffset = characterController.stepOffset;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();

        ySpeed += Physics.gravity.y * Time.deltaTime;

        

        if (characterController.isGrounded)
        {
            characterController.stepOffset = originalStepOffset;
            ySpeed = -0.5f;
            isJumping = false;
            if (movementDirection != Vector3.zero){
                isWalking = true;
                
            }else {
                isWalking = false;
                // isIdle = true;
            }

            if (Input.GetButtonDown("Jump"))
            {
                ySpeed = jumpSpeed;
                isWalking = false;
                isJumping = true;
            }
        }
        else
        {
            characterController.stepOffset = 0;
        }

        Vector3 velocity = movementDirection * magnitude;
        velocity.y = ySpeed;

        characterController.Move(velocity * Time.deltaTime);

         if (movementDirection != Vector3.zero)
        {
            // isIdle = false;
            gameObject.transform.forward = Vector3.Slerp(transform.forward, movementDirection, Time.deltaTime * rotationSpeed);
        }
    }

    public bool IsWalking()
    {
        return isWalking;
    }

    public bool IsJumping()
    {
        return isJumping;
    }

    // public bool IsIdle()
    // {
    //     return isIdle;
    // }
}