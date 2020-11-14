using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    public TrackAreaController trackAreaController;
    public bool trainHeld;
    public bool movementStarted;

    void Update()
    {
        if (trainHeld == true)
        {
            trackAreaController.previousTarget = trackAreaController.currentTarget;
            trackAreaController.currentTarget = null;
            trackAreaController.trainSpeed = 0f;
        }
        else
        {
            SetFirstMoveTowardsPosition();
            trackAreaController.trainSpeed = 0.5f;
            trackAreaController.currentTarget = trackAreaController.previousTarget;
            transform.position = Vector3.MoveTowards(transform.position, trackAreaController.currentTarget.position, Time.deltaTime * trackAreaController.trainSpeed);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trainHeld = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trainHeld = false;
        }
    }

    void SetFirstMoveTowardsPosition()
    {
        if (movementStarted == false && trainHeld != true)
        {
            trackAreaController.currentTarget = trackAreaController.testingTarget;
            trackAreaController.previousTarget = trackAreaController.currentTarget;
            movementStarted = true;
        }
    }
}
