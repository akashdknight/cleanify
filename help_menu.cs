using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class help_menu : MonoBehaviour
{
   public void back()
   {
        SceneManager.LoadScene(0);
   }

   public void controls()
   {
        SceneManager.LoadScene(4);

   }

   public void objects()
   {
        SceneManager.LoadScene(6);
   }
}
