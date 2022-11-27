using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class upgrade_menu : MonoBehaviour
{
   public void back()
   {
        SceneManager.LoadScene(0);
   }

   public void upgrade()
   {
        Debug.Log("Later babes");
   }
}
