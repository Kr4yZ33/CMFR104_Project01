using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    public AudioManager audioManager; // reference to the Audio Manager script
    public GameManager gameManager; // reference to the Game Manager
    public AudioSource audioSource; // Reference to our Audio SOurce

    public bool edgeTransition; // bool for if tile waypoint edge transition is true or not

    public Transform startingPos; // reference to the transform the train will jump to when the scene starts
    public Vector3 targetPosition; // reference to our target position
    public Transform currentTarget; // the transform the train is currently targeting
    public Transform previousTarget; // the previous transform target of the train

    public float trainSpeed = 0.5f; // the speed of the train

    public bool trainPassedTrainStationTrackOne; // a bool for if the train has passed the train station yet

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = startingPos.position; // set the target position to the starting poisition
        transform.position = targetPosition; // set the position of the transform this script is attached to, to the target position transform
             
    }

    private void LateUpdate()
    {
        if (gameManager.startMissionComplete == true) // if the start mission complete bool on the Game Manager Script is equal to true
        {
            audioSource.Play(); // play the audio source
            targetPosition = currentTarget.position; // set the target position to the current target
            trainSpeed = 0.5f; // set the train speed to 0.05f
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * trainSpeed); // make the transform of the object this script is attached to move towards the target position using delta time at the train speed set (0.5)
        }
    }


    void OnTriggerEnter(Collider other) // on trigger enter
    {
        if(other.CompareTag("TrainStation") && gameManager.fourthMissonInProgress == true) // if the thing colliding with us is tagged Train Station & the fourth mission in progress bool on the Game Manager is equal to true
        {
            trainPassedTrainStationTrackOne = true; // set the train passed train station bool to true
        }

        if (other.CompareTag("HornSpawn")) // if the thing colliding with me is tagged HornSpawn
        {
            PlayTrainHorn(); // call the PLayTrainHorn function
        }

        if (other.CompareTag("TrackEdge")) // if the thing colliding with me is tagged TrackEdge
        {
            edgeTransition = true; // set the edgeTransition bool to true
        }
    }

    void OnTriggerExit(Collider other) // on trigger exit
    {

        if (other.CompareTag("TrackEdge")) // if the thing colliding with me is tagged TrackEdge
        {
            edgeTransition = false; // set the edge transition bool to false
        }
    }

    /// <summary>
    /// Play the audio for the train's horn
    /// </summary>
    void PlayTrainHorn()
    {
        audioManager.PlayHornClip(); // call the PLayHornClip from the audio manager script
    }
}
