﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Security.Cryptography;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
       
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Manager>().EndGame();
        }
    }
}
