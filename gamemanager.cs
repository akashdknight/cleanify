using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public static gamemanager Instance;
    public int score;
    public float speed;

    public float level = 1;
    public float numberofspawns = 400;
    public float target = 50;  ///// isko change kra hai...

    private void Awake() 
    {   
        if(Instance != null)
        {
            Destroy(gameObject);
            return ;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);    
    }

    public void start_game()
    {
        SceneManager.LoadScene(1);    
        speed = FindObjectOfType<movement>().speed;   
        FindObjectOfType<scoresheet>().score = 0;
        FindObjectOfType<timecounting>().seconds = 120;

        int x = FindObjectOfType<metadata>().game_level;
        level = level > x ? level : x;
        target = target + 50;
        Debug.Log(level);
    }

    public void  game_over()
    {
        FindObjectOfType<metadata>().saveplayer();
        FindObjectOfType<movement>().enabled = false;
        FindObjectOfType<camera_follow>().enabled = false;        
        score = FindObjectOfType<scoresheet>().score;

        if(score >= target)
        {
            SceneManager.LoadScene(3); //level completed wala
        }
        else
        {
            SceneManager.LoadScene(2);
        }
        //FindObjectOfType<gameover>().show_data(score);                
    }
    

    void Start() 
    {
        //start_game();
    }
}
