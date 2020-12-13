using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverChangeUIButtons : MonoBehaviour
{
    Renderer r; // private reference to the renderer of the object this script is attached to

    void Start()
    {
        r = GetComponent<Renderer>(); // on start get the renderer of this game object and assign it to r
    }

    /// <summary>
    /// function to make the object green
    /// </summary>
    public void MakeGreen()
    {
        r.material.color = Color.green; // set the renderer colour to green
    }

    /// <summary>
    /// function to make the object red
    /// </summary>
    public void MakeRed()
    {
        r.material.color = Color.red; // set the renderer colour to red
    }
}
