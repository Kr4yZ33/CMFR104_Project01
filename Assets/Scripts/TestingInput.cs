using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingInput : MonoBehaviour
{
    public GameObject cube; // reference to our cube game object
    Renderer r; // private reference to the renderer

    // Start is called before the first frame update
    void Start()
    {
        r = cube.transform.gameObject.GetComponent<Renderer>(); // renderer is equal to the renderer of the cube object this script is attached to
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Controller activeController = OVRInput.GetActiveController(); // Sets the OVR Input for the active controller


        float indexTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger); // float for if the primary index finger is pressed
        if (indexTrigger != 0.0f) // if the indexTrigger value is not equal to 0
        {

            r.material.color = Color.blue; // make the cube colour blue
        }


    }
}