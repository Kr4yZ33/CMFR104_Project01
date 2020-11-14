using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackAreaController : MonoBehaviour
{
    public Transform currentTarget;
    public Vector3 targetVector;

    public Transform previousTarget;
    public Vector3 previousVector;

    public Transform initialTarget;
    public Vector3 initialVector;

    public Transform testingTarget;

    public float trainSpeed = 0.5f;

    private void Start()
    {
        currentTarget = testingTarget;
    }

    // Update is called once per frame
    void Update()
    {
        targetVector = currentTarget.position;
        previousVector = previousTarget.position;
        initialVector = initialTarget.position;

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
