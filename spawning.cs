using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{   
    public GameObject[]  spawns;
    int no_of_spawns = 30;

    public GameObject rubbish;
    // Start is called before the first frame update
    void Start()
    {
        spawns = GameObject.FindGameObjectsWithTag("spawn_point");
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.L))
        {   
            bool[] markers = new bool[spawns.Length];
            for(int i = 0; i < spawns.Length; i++)markers[i] = false;

            for(int i = 0; i < no_of_spawns && i < spawns.Length; i++)
            {
                int index = Random.Range(0, spawns.Length);
                if(!markers[index])
                {
                    markers[index] = true;
                    Instantiate(rubbish, spawns[index].transform.position, Quaternion.identity);
                }
                else
                {
                    for(int j = index; j < spawns.Length; j++)
                    {
                        if(!markers[j])
                        {
                            markers[j] = true;
                            Instantiate(rubbish, spawns[j].transform.position, Quaternion.identity);
                        }
                    }
                }
            }
            // Vector3 pos = new Vector3(-262, 75, 14);
            // Instantiate(coins, pos, Quaternion.identity);
        }
        
    }
}
