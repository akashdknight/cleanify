using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{   
    private GameObject[]  spawns;
    public GameObject[] trash;
    public GameObject[] obstacle;

    int no_of_spawns = 400;
    int obstacle_spawns = 80;

    Vector3 offset = new Vector3(0,1,0);

    //public GameObject rubbish;
    // Start is called before the first frame update
    void Start()
    {
        spawns = GameObject.FindGameObjectsWithTag("spawn_point");

        bool[] markers = new bool[spawns.Length];
        for(int i = 0; i < spawns.Length; i++)markers[i] = false;

        
        int trash_index = 0;
        for(int i = 0; i < no_of_spawns && i < spawns.Length; i++)
        {
            int index = Random.Range(0, spawns.Length);
            while(markers[index])index = Random.Range(0, spawns.Length);
            //Debug.Log(index);
            trash_index = (trash_index + 1)%trash.Length;

            if(!markers[index])
            {
                markers[index] = true;
                Instantiate(trash[trash_index], spawns[index].transform.position + offset, Quaternion.identity);
            }            
        }

        int obstacle_index = 0;
        for(int i = 0; i < obstacle_spawns && i < spawns.Length; i++)
        {
            int index = Random.Range(0, spawns.Length);
            while(markers[index])index = Random.Range(0, spawns.Length);
            obstacle_index = (obstacle_index + 1)%obstacle.Length;

            Instantiate(obstacle[obstacle_index], spawns[index].transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    { 
           
    }
}
