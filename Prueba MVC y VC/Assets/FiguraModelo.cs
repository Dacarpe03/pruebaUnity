using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class FiguraModelo
{
    private Vector3 position;
    public Vector3 Position
    {
        get
        {
            return position;
        }
    }

    public FiguraModelo()
    {
        position = Vector3.zero;
    }

    public void Move()
    {
        position.x += 7f*Time.deltaTime;
    }
    
}
