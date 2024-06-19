using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{

    public Transform body;

    CharacterController characterController;

    private Vector3 movement = Vector3.zero;


    //movement

    public float speed;

    /*public float walkSpeed;

    public float runSpeed;*/







    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {


        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement.x = horizontal;
        //movement.z = vertical;


        characterController.Move(movement * speed * Time.deltaTime);





    }
}
