﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{

    public bool trainHeld;
    public bool edgeTransition;

    public Transform startingPos;
    public Vector3 targetPosition; // reference to our target position
    public Transform currentTarget;
    public Transform previousTarget;

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
            currentTarget = previousTarget;
            currentTarget = null;
            trainSpeed = 0f;
        }
        else
        {
            targetPosition = currentTarget.position;
            trainSpeed = 0.5f;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * trainSpeed);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            trainHeld = true;
        }

        if(other.CompareTag("TrackEdge"))
        {
            edgeTransition = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trainHeld = false;
        }

        if (other.CompareTag("TrackEdge"))
        {
            edgeTransition = false;
        }
    }
}
