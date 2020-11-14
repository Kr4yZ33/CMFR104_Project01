using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainTestMovement : MonoBehaviour
{
    public TrackAreaController trackAreaController;
    
    public Vector3 targetPosition; // reference to our target position
    public Transform startingPos; // The transform postion we start from
    // public Transform endPos; // The transform position we are ending at
    public float minDistanceToTarget = 0.1f; // need to check this with Nathan but I think it's the distance where the Gaurd Capsule says its too close to the A or B transform position
    public float speed = 0.5f; // the speed the gaurd capsule moves at 

    // Start is called before the first frame update
    void Start()
    {
        startingPos = trackAreaController.currentTarget;

        targetPosition = startingPos.position;
        transform.position = targetPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);

        if (Vector3.Distance(transform.position, targetPosition) <= minDistanceToTarget)
        {
            if (targetPosition == startingPos.position)
            {
                // stop the train for a short time before starting moving again
                //targetPosition = endPos.position;
            }
            //else if (targetPosition == endPos.position)
            //{
                //targetPosition = startingPos.position;
            //}
        }
    }
}
