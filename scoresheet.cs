using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoresheet : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI targettext;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {           
        scoretext.text = "Score : " + score.ToString();
        float target = FindObjectOfType<gamemanager>().target;
        targettext.text = target.ToString();
        //Debug.Log(playerpos.position.x);
    }
}
