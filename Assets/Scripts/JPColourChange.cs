using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JPColourChange : MonoBehaviour
{
    Renderer r; // reference to the renderer

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>(); // get the renderer component from the object this script is attached to
    }

    public void SetRed() // function to set the red colour
    {
        r.material.color = Color.red; // set colour red
    }

    public void SetGreen() // function to set the red colour
    {
        r.material.color = Color.green; // set colour green
    }
}