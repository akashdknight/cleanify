//attached to Canvas > Time

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timecounting : MonoBehaviour
{
    public int seconds = 10;
    bool deducting = false;
    public TextMeshProUGUI timetext;

    // Update is called once per frame
    void Update()
    {
        if(!deducting)
        {
            deducting = true;
            StartCoroutine(Deduct());
        }     
    }

    IEnumerator Deduct()
    {
        yield return new WaitForSeconds(1);
         
        seconds-=1;
        if(seconds >= 0)
        {
            timetext.text = seconds.ToString() + " secs";
            deducting = false;
        }    
        else
        {
            deducting = true;
            FindObjectOfType<movement>().animator_control.SetBool("is_moving", false);
            FindObjectOfType<gamemanager>().game_over();
            // FindObjectOfType<movement>().enabled = false;
            // FindObjectOfType<camera_follow>().enabled = false;
        }
    }
}
