using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiguraVista : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Move(Vector3 position)
    {
        transform.position = position;
    }
}
