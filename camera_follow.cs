
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform player_pos;
    float height_offset = 5f;
    float gap_offset = 9f;
    

    private bool turnleft = false;
    private bool turnright = false;
    
    public float angle = 0;
    
    //0 facing -x
    //90 facing +z
    //180 facing +x
    //270 facing -z
    
    void Update()
    {   
        
        if(Input.GetKeyDown(KeyCode.RightArrow))turnright = true;
        if(Input.GetKeyDown(KeyCode.LeftArrow))turnleft = true;
       

        if(turnright)
        {
            turnright = false;
            transform.Rotate(new Vector3(0f, 90f, 0f));
            angle = (angle + 90)%360;
            
        }
        else if(turnleft)
        {   
            turnleft = false;
            transform.Rotate(new Vector3(0f, -90f, 0f));
            angle = (angle + 270)%360;
        }

        if(angle == 0)
        {   
            transform.position = player_pos.position + new Vector3(gap_offset, height_offset,0);
            
        }
        else if(angle == 90)
        {
            transform.position = player_pos.position + new Vector3(0, height_offset,-gap_offset);
        }
        else if(angle == 180)
        {
            transform.position = player_pos.position + new Vector3(-gap_offset, height_offset,0);
        }
        else if(angle == 270)
        {
            transform.position = player_pos.position + new Vector3(0, height_offset,gap_offset);
        }
    }
}
// using UnityEngine;

// public class camera_follow : MonoBehaviour
// {
//     public Transform target;
//     public float trailDistance = 5.0f;
//     public float heightOffset = 3.0f;
//     public float cameraDelay = 0.02f;

//     // Update is called once per frame
//     void Update()
//     {
//         Vector3 followPos = target.position - target.forward * trailDistance;

//         followPos.y += heightOffset;
//         transform.position += (followPos - transform.position) * cameraDelay;

//         transform.LookAt(target.transform);
//     }
// }