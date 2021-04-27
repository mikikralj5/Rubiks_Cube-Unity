﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRed : ColorState
{
   

    public override void ChagneColor(Color color, GameObject player)
    {
        List<UnityEngine.Color> colors = new List<UnityEngine.Color>(2)
        {
             new UnityEngine.Color(0, 0, 128), //blue
             new UnityEngine.Color(255,255,0) //yellow
    };
       
        player.tag = "ColorRed";
        int index = Random.Range(0, 2);
        player.GetComponent<Renderer>().material.color = colors[index];
        ChangeState(color, index);
    }

    public override void ChangeState(Color color, int index)
    {

        if (index == 0)
            color.state = new ColorBlue();
        else
            color.state = new ColorYellow();
    }

    public override void CollisionChangeUp(GameObject player)
    {
        player.GetComponent<PlayerController>().ForwardSpeed += 0.5f;
    }

    public override void CollisionChangeDown(GameObject player)
    {
        player.GetComponent<PlayerController>().ForwardSpeed -= 0.3f;
    }
}