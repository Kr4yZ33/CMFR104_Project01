using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    public AudioManager audioManager;

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
             
    }

    void Update()
    {
               
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
        if (other.CompareTag("HornSpawn"))
        {
            PlayTrainHorn();
        }

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
            currentTarget = startingPos;
        }

        if (other.CompareTag("TrackEdge"))
        {
            edgeTransition = false;
        }
    }

    void PlayTrainHorn()
    {
        audioManager.PlayHornClip();
    }
}
