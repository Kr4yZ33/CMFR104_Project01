using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverChange : MonoBehaviour
{
    //Renderer r;
    //Color originalColor;
    public GameObject trackMesh;

    //void Start()
    //{
        //r = GetComponent<Renderer>();
        //originalColor = r.material.color;
    //}

    //public void MakeGrey()
    //{
        //r.material.color = Color.grey;
    //}

    public void HoverColour()
    {
        trackMesh.SetActive(false);
    }

    public void MakeOriginalColour()
    {
        //r.material.color = originalColor;
        trackMesh.SetActive(true);
    }
}
