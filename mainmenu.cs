using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene(1);
        // SceneManager.LoadScene(0);
        Debug.Log("starting the game");
    }

    public void help()
    {
        SceneManager.LoadScene(5);
    }

    public void upgrade()
    {   
        SceneManager.LoadScene(7);
        Debug.Log("store opening");
    }

    public void exit()
    {   
        Debug.Log("Game exited");
        Application.Quit();
    }
}
