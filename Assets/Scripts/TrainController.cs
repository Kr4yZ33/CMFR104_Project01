using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    public TrackAreaController trackAreaController;
    public bool trainHeld;
    public bool movementStarted;

    public Transform startingPos;

    public float minDistanceToTarget = 0.1f;

    public Vector3 targetPosition; // reference to our target position
    
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = startingPos.position;
        transform.position = targetPosition;
    }

   void Update()
    {
        if (trainHeld == true)
        {
            trackAreaController.previousTarget = trackAreaController.currentTarget;
            trackAreaController.trainSpeed = 0f;
        }
        else
        {
            targetPosition = trackAreaController.currentTarget.position;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * trackAreaController.trainSpeed);

            if (Vector3.Distance(transform.position, targetPosition) <= minDistanceToTarget)
            {
                
                if (targetPosition == startingPos.position)
                {
                    movementStarted = true;
                    targetPosition = trackAreaController.currentTarget.position;
                }

            }
            //SetFirstMoveTowardsPosition();

            if (targetPosition != startingPos.position)
            {
                targetPosition = trackAreaController.currentTarget.position;
            }

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

    //void SetFirstMoveTowardsPosition()
    //{
        //if (movementStarted == false && trainHeld != true)
        //{
            //trackAreaController.currentTarget = trackAreaController.testingTarget;
            //trackAreaController.previousTarget = trackAreaController.currentTarget;
            //movementStarted = true;
        //}
    //}
}
