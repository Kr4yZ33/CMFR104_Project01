using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackAreaController : MonoBehaviour
{

    public TrainController trainController;
    public Transform currentTarget;
    public Transform previousTarget;
    public Transform initialTarget;
    public Transform testingTarget;

    public float trainSpeed = 0.5f;


    // Update is called once per frame
    void Update()
    {
        if (trainController.trainHeld == true)
        {
            return;
        }
        else if (currentTarget == null)
        {
            currentTarget = testingTarget;
            // add if null find closest transform tagged with edge or middle that does not have the bool train passing as true, then apply speed and move towards that transform
        }
    }
}
