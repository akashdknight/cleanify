using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene(0);
        // SceneManager.LoadScene(0);

        Debug.Log("starting the game");
    }

    public void help()
    {

    }

    public void upgrade()
    {

    }

    public void exit()
    {   
        Debug.Log("Game exited");
        Application.Quit();
    }
}
