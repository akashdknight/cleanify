using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class level_completed : MonoBehaviour
{   
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI coinstext;
    public TextMeshProUGUI totalcoins;
    public TextMeshProUGUI high_score;


    int coins_multiplier = 13;

    void Start()
    {   
        //SceneManager.LoadScene(1);
        //int score = FindObjectOfType<scoresheet>().score;
        int score = FindObjectOfType<gamemanager>().score;
        int high = FindObjectOfType<metadata>().high_score;
        high = high > score ? high : score;
        FindObjectOfType<metadata>().high_score = high;

        int tcoins = FindObjectOfType<metadata>().coins;

        scoretext.text = "Your Score : " + score.ToString();

        int coins = score*coins_multiplier;
        tcoins = coins + tcoins;
        FindObjectOfType<metadata>().coins = tcoins;
        coinstext.text = "Coins Earned : " + coins.ToString();

        totalcoins.text = "Total Coins : " + tcoins.ToString();
        high_score.text = "High Score : " + high.ToString();

        FindObjectOfType<metadata>().saveplayer();        
    }

    public void restart_level()
    {           
        SceneManager.LoadScene(1);
        FindObjectOfType<metadata>().saveplayer();
    }

    public void main_menu()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<metadata>().saveplayer();
    }

    public void next_level()
    {
        FindObjectOfType<metadata>().game_level+=1;
        FindObjectOfType<gamemanager>().level+=1;
        FindObjectOfType<metadata>().saveplayer();

        FindObjectOfType<gamemanager>().start_game();
    }

}
