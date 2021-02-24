﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Box")
        {
            rend.sharedMaterial = material[0];
        }
        else 
        {
            rend.sharedMaterial = material[1];
        }
    }
}

