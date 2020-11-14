using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackAreaController : MonoBehaviour
{
    public Transform currentTarget;
    public Transform previousTarget;
    public Transform initialTarget;

    public Transform testingTarget;

    public float trainSpeed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (currentTarget == null)
        {
            currentTarget = previousTarget;
            if (previousTarget == null)
            {
                Debug.Log("Previous Target not set");
                
            }
            
        }
    }
}
