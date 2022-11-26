using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles : MonoBehaviour
{   
    //public scoresheet score_sheet;

    void OnTriggerEnter(Collider player)
    {   
        FindObjectOfType<scoresheet>().score+=1;
        gameObject.SetActive(false);
        Debug.Log("Collected");
    }

    public int  rotatespeed = 1;

    void Update()
    {
        transform.Rotate(0, rotatespeed, 0, Space.World);
    }
}
