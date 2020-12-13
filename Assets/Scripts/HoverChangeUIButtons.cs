using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverChangeUIButtons : MonoBehaviour
{
    Renderer r;

    void Start()
    {
        r = GetComponent<Renderer>();
    }

    public void MakeGreen()
    {
        r.material.color = Color.green;
    }

    public void MakeRed()
    {
        r.material.color = Color.red;
    }
}
