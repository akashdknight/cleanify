using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameover : MonoBehaviour
{   
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI coinstext;

    int coins_multiplier = 13;

    void Start()
    {   
        //SceneManager.LoadScene(1);
        //int score = FindObjectOfType<scoresheet>().score;
        int x = FindObjectOfType<gamemanager>().score;
        int score = x;
        scoretext.text = "Your Score : " + score.ToString();

        int coins = score*coins_multiplier;
        coinstext.text = "Coins Earned : " + coins.ToString();

        Debug.Log("I am called");
    }

    public void restart_level()
    {           
        SceneManager.LoadScene(0);
    }

    public void main_menu()
    {
        SceneManager.LoadScene(2);
    }

}
