using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{

    public Transform body;

    CharacterController characterController;

    private Vector3 movement = Vector3.zero;

    public TimeManager time;


    //movement

    public float speed;

    /*public float walkSpeed;

    public float runSpeed;*/

    private GameObject boy;

    public Animator anim;







    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();  
        boy = GameObject.Find("Boy");

        anim = boy.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement.x = horizontal;
        //movement.z = vertical;


        characterController.Move(movement * speed * Time.deltaTime);

        float TargetAngle = Mathf.Atan(horizontal) * Mathf.Rad2Deg;

        //body.rotation = Quaternion.Euler(0f,TargetAngle,0f);

        if (TargetAngle == 0)
        {
            anim.SetInteger("state", 0);
        }

        if (TargetAngle < 0)
        {
            anim.SetInteger("state", 1);
        }

        if (TargetAngle > 0)
        {
            anim.SetInteger("state", 2);
        }

        if(time.TimeRemaining <= 0)
        {
            anim.SetInteger("state", 4);
        }
        





        //Debug.Log(TargetAngle);






    }
}
