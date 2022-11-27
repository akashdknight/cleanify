using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class playerdata
{
    public int player_level;
    public int game_level;
    public int coins;
    public float spd;
    public int high_score;

    public playerdata (metadata info)
    {
        player_level = info.player_level;
        game_level = info.game_level;
        coins = info.coins;
        spd = info.spd;
        high_score = info.high_score;
    }
}
