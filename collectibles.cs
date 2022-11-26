using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles : MonoBehaviour
{
    void OnTriggerEnter(Collider player)
    {
        gameObject.SetActive(false);
        Debug.Log("Collected");
    }
}
