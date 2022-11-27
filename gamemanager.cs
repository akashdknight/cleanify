using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public static gamemanager Instance;
    public int score;

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
        SceneManager.LoadScene(0);       
        FindObjectOfType<scoresheet>().score = 0;
        FindObjectOfType<timecounting>().seconds = 30;
    }

    public void  game_over()
    {
        FindObjectOfType<movement>().enabled = false;
        FindObjectOfType<camera_follow>().enabled = false;        
        score = FindObjectOfType<scoresheet>().score;
        SceneManager.LoadScene(1);
        //FindObjectOfType<gameover>().show_data(score);                
    }
}
