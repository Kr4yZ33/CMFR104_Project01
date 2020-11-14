using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    public TrackAreaController trackAreaController;
    public bool trainHeld;

    private void Update()
    {
        if (trainHeld == true)
        {
            trackAreaController.previousTarget = trackAreaController.currentTarget;
            trackAreaController.currentTarget = null;
            trackAreaController.trainSpeed = 0f;
        }
        
        if(trainHeld != true)
        {
            trackAreaController.trainSpeed = 0.5f;
            transform.position = Vector3.MoveTowards(transform.position, trackAreaController.targetVector, Time.deltaTime * trackAreaController.trainSpeed);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trainHeld = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            trainHeld = false;
        }
    }
}
