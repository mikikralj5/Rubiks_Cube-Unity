﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    public ColorState state;
    
    void Start()
    {
        state = new ColorRed();
        InvokeRepeating("ChangeColor", 2, 2);
      
    }
    void ChangeColor()
    {
        state.ChagneColor(this,gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Platform is" + other.tag);
        Debug.Log("State is" + state.GetType().Name);
        if(other.CompareTag(state.GetType().Name))
        {
            state.CollisionChangeUp(gameObject);

            Debug.Log("speedup");
        }
        else if(!other.CompareTag(state.GetType().Name))
        {
            state.CollisionChangeDown(gameObject);
            Debug.Log("slowed");
        }
       
    }
}