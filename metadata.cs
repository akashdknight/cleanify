using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class metadata : MonoBehaviour
{
    public int player_level = 1;
    public int game_level = 1;
    public int coins = 0;
    public float spd = 0;
    public int high_score = 0;


    public void saveplayer()
    {
        savefile.SavePlayer(this);
    }

    void Start()
    {
        playerdata data = savefile.LoadPlayer();
        spd = FindObjectOfType<gamemanager>().speed;
        
        if(data != null)
        {
            player_level = data.player_level;
            coins = data.coins;
            game_level = data.game_level;
            spd = data.spd;
            high_score = data.high_score;
        }

        // if(SceneManager.GetActiveScene().buildIndex == 1)
        // {
        //     //FindObjectOfType<movement>().speed = spd;
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
