using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{   
    private GameObject[]  spawns;
    public GameObject[] trash;
    public GameObject example;
    int no_of_spawns = 200;
    Vector3 offset = new Vector3(0,1,0);
    //public GameObject rubbish;
    // Start is called before the first frame update
    void Start()
    {
        spawns = GameObject.FindGameObjectsWithTag("spawn_point");

        bool[] markers = new bool[spawns.Length];
        for(int i = 0; i < spawns.Length; i++)markers[i] = false;

        Debug.Log(spawns.Length);
        int trash_index = 0;
        for(int i = 0; i < no_of_spawns && i < spawns.Length; i++)
        {
            int index = Random.Range(0, spawns.Length);
            while(markers[index])index = Random.Range(0, spawns.Length);
            Debug.Log(index);
            trash_index = (trash_index + 1)%trash.Length;

            if(!markers[index])
            {
                markers[index] = true;
                Instantiate(trash[trash_index], spawns[index].transform.position + offset, Quaternion.identity);
            }
            // else
            // {
            //     for(int j = index; j < spawns.Length; j++)
            //     {
            //         if(!markers[j])
            //         {
            //             markers[j] = true;
            //             Instantiate(trash[trash_index], spawns[j].transform.position, Quaternion.identity);
            //         }
            //     }
            // }
        }
    }

    // Update is called once per frame
    void Update()
    {   
        // if(Input.GetKeyDown(KeyCode.L))
        // {

        // Vector3 pos = new Vector3(-225, 72, 10);
        // //Instantiate(example, pos, Quaternion.identity);
        // Instantiate(example, pos, Quaternion.identity);
        // Debug.Log("done");
        // }
        
            // Vector3 pos = new Vector3(-262, 75, 14);
            // Instantiate(coins, pos, Quaternion.identity);
        
        
    }
}
