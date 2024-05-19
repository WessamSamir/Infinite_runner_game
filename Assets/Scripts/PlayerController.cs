using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private CharacterController controller;
    private Vector3 dir;
    public float forwardSpeed;
    public float jumpForce;
    public float Gravity = -20;

    private int desiredLane = 1;//0:left, 1:middle, 2:right
    public float laneDistance = 4;
    [SerializeField] AudioSource JumpSound;



    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        dir.z = forwardSpeed;

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
                JumpSound.Play();
                
            }
        }
        else
        {
            dir.y += Gravity * Time.deltaTime;

        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }
        Vector3 targetPosition = transform.position.z * transform.forward +
                    transform.position.y * transform.up;

        if (desiredLane == 0)
            targetPosition += Vector3.left * laneDistance;
        else if (desiredLane == 2)
            targetPosition += Vector3.right * laneDistance;


       if (transform.position != targetPosition)
        {
            Vector3 diff = targetPosition - transform.position;
            Vector3 moveDir = diff.normalized * 30 * Time.deltaTime;
            if (moveDir.sqrMagnitude < diff.magnitude)
                controller.Move(moveDir);
            else
                controller.Move(diff);
        }

        controller.Move(dir * Time.deltaTime);

    }
    private void FixedUpdate()
    {
        controller.Move(dir * Time.fixedDeltaTime);
    }

    private void Jump()
    {
        dir.y = jumpForce;
    }

    

    

}
