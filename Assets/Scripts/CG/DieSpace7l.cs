﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpace7l : MonoBehaviour
{
    public GameObject respawn;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            other.transform.position = respawn.transform.position;
        }
    }

}
