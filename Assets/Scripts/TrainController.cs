using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    public bool trainHeld;
    //public bool movementStarted;
    public bool edgeTransition;
    
    public Transform startingPos;
    public Vector3 targetPosition; // reference to our target position
    public Transform currentTarget;
    public Transform previousTarget;

    public float minDistanceToTarget = 0.01f;
    public float trainSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = startingPos.position;
        transform.position = targetPosition;
            
        if(currentTarget == null)
        {
            currentTarget = startingPos;
        }   
    }

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


        if (trainHeld == true)
        {
            previousTarget = currentTarget;
            currentTarget = null;
            trainSpeed = 0f;
        }
        else
        {
            targetPosition = currentTarget.position;
            trainSpeed = 0.5f;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * trainSpeed);

            //if (Vector3.Distance(transform.position, targetPosition) <= minDistanceToTarget)
            //{
                
                //if (targetPosition == startingPos.position)
                //{
                    //movementStarted = true;
                    //targetPosition = currentTarget.position;
                //}

            //}
            //SetFirstMoveTowardsPosition();

            if (targetPosition != startingPos.position)
            {
                targetPosition = currentTarget.position;
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
