﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winconjoystick : MonoBehaviour
{


    void OnTriggerEnter (Collider other)
    {
         if (other.name == "Player")
            {
            SceneManager.LoadScene(6);
            Debug.Log("triggered");
            }
    }
   


}
