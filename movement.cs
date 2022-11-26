
// using UnityEngine;

// public class movement : MonoBehaviour
// {   
//     public Rigidbody player;
//     float force = 50f;
//     float sideforce = 25f;
//     float angle = 0;
//     //0 facing -x
//     //90 facing +z
//     //180 facing +x
//     //270 facing -z
    
//     public void move_forward()
//     {
//         if(angle == 0)player.AddForce(-force,0, 0);
//         else if(angle == 90)player.AddForce(0,0,force);
//         else if(angle == 180)player.AddForce(force,0,0);
//         else player.AddForce(0,0,-force);
//     }
//     //by default right keliye, left keliye negative force pass karo.
//     public void move_side(float side_force)
//     {
//         if(angle == 0)player.AddForce(0,0,side_force);
//         else if(angle == 90)player.AddForce(side_force, 0, 0);
//         else if(angle == 180)player.AddForce(0,0,-side_force);
//         else player.AddForce(-side_force, 0, 0);
//     }


//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     void Update()
//     {
//         angle = FindObjectOfType<camera_follow>().angle;
//     }
   
    
//     // Update is called once per frame
//     void FixedUpdate()
//     {
//         if(Input.GetKey("w"))
//         {
//             move_forward();
//         }
//         if(Input.GetKey("a"))
//         {
//             move_side(-sideforce);
//         }
//         if(Input.GetKey("d"))
//         {
//             move_side(sideforce);
//         }
        
//     }
// }


using UnityEngine;

public class movement : MonoBehaviour
{
    private bool turnLeft, turnRight, stop;
    private float speed = 5f;
    private CharacterController controller;
    private Vector3 move_direction = Vector3.zero;
    private float gravity = -3;
    private float angle = 0;
    //0 facing -x
    //90 facing +z
    //180 facing +x
    //270 facing -z
    // Start is called before the first frame update

    public void move_forward()
    {
        if(angle == 0)move_direction.x = -1;
        else if(angle == 90)move_direction.z = 1;
        else if(angle == 180) move_direction.x = 1;
        else move_direction.z = -1;
    }
    //move side is by default right;
    public void move_side(int side)
    {
        if(angle == 0)move_direction.z = 1*side;
        else if(angle == 90)move_direction.x = 1*side;
        else if(angle == 180)move_direction.z = -1 * side;
        else move_direction.x = -1*side;
    }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private Animator animator_control;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator_control = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        turnLeft = Input.GetKeyDown(KeyCode.LeftArrow);
        turnRight = Input.GetKeyDown(KeyCode.RightArrow);
        stop = Input.GetKeyDown(KeyCode.S);

        angle = FindObjectOfType<camera_follow>().angle;
        move_direction = Vector3.zero;
        if(controller.isGrounded)
        {   
            
            if (turnLeft)transform.Rotate(new Vector3(0f, -90f, 0f));               
            else if (turnRight)transform.Rotate(new Vector3(0f, 90f, 0f));              
            bool is_moving = false;  // boolean flag to check whether player is moving or not (animation transition)

            if(Input.GetKey("a"))
            {
                move_side(-1);
                is_moving = true;
            }
            else if(Input.GetKey("d"))
            {
                move_side(1);
                is_moving = true;
            }

            if(Input.GetKey("w"))
            {
                move_forward();
                is_moving = true;
            }
            // controller.SimpleMove(new Vector3(0f, 0f, 0f));
            //if(!stop)controller.Move(transform.forward * speed);
            if(!stop)controller.Move(move_direction*speed*Time.deltaTime);
            animator_control.SetBool("is_moving", is_moving);
            
        }
        move_direction = Vector3.zero;
        move_direction.y += gravity;
        if(!stop)controller.Move(move_direction);
        
    }
}


