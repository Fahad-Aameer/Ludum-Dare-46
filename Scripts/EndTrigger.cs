﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Cat")
        {
            gameManager.CompleteLevel();
        }

    }
}
