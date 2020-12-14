using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SpatialTracking;

public class TrainExitTile : MonoBehaviour
{
    public PlayerRespawn playerRespawn; // reference to the PLayer Respawn script

    public AudioClip allABoard; // reference to the All aboard Audio Clip
    public AudioSource audioSource;// reference to the audio source
    public float volume = 0.5f; //float for setting the volume

    public bool trainExitTilePlaced; // bool for if the train exit tile has been placed
    public bool ridingTrain; // bool for if the player is riding the train
    public bool passedStationWhileRidingTrain; // bool for if the train station has been passed while riding the train
    public bool buildPlatformInRange; // bool to check if the build platform is in range of the train exit tile (e.g. it's not placed up in the air away from the track, would would trap the player on the train ride).
    
    public GameObject trainRideRigCamera; // reference to the camera used for riding the train

    // I had a lot of trouble with disabling the VR rig and/or trying to re-scale it. I ended up having to disable the VR rig camera and hands, then enable a camera on the train.
    public GameObject vRRig; // reference to our VR rig
    public GameObject rightHand; // reference to our right hand
    public GameObject rightHandRay; // reference to our right hand ray
    public GameObject leftHand; // reference to our left hand on the rig
    public GameObject leftHandRay; // reference to our left hand ray.

    /// <summary>
    /// on Trigger enter
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TilePlatform")) // if the thing colliding with us is tagged Tile Platform
        {
            buildPlatformInRange = true; // set the bool for build platform in range to true
        }

        if (other.CompareTag("Train") && ridingTrain == true) // if the thing colliding with us is tagged Train & the bool for riding the train is true
        {
            ExitTheTrain(); // call the exit the train function
        }
        
        if(other.CompareTag("TrackMesh")) // is the thing colliding with us is tagged TrackMesh
        {
            trainExitTilePlaced = true; // set the bool for train exit tile placed to true (another words the train exit tile is actually touching track, which will stop the player getting trapped on the train ride).
        }
    }

    /// <summary>
    /// on trigger exit
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TrackMesh")) // if the this leaving our collider is tagged TrackMesh
        {
            trainExitTilePlaced = false; // set the bool for train exit tile placed to false
        }

        if (other.CompareTag("TilePlatform")) // if the this leaving our collider is tagged Tile Platform
        {
            buildPlatformInRange = false; // set the bool for builid platform in range to false
        }
    }


    /// <summary>
    /// public function called to ride the train
    /// </summary>
    public void RideTheTrain()
    {
        RideTheTrainVRDisable();
        ridingTrain = true; // set the bool for riding the train to true
        audioSource.PlayOneShot(allABoard, volume); // play the all aboard audio clip as a play one shot
    }

    /// <summary>
    /// private function for exiting the train, again to prevent the player from being trapped
    /// </summary>
    void ExitTheTrain()
    {
        ExitTheTrainCameraDisable();
        ridingTrain = false; // set the bool for riding the train to false
        passedStationWhileRidingTrain = false; // set the bool for passed station while riding train to false   
    }

    void RideTheTrainVRDisable()
    {
        vRRig.SetActive(false); // disable our VR rig camera (careful originally it was the whole rig, now only the main camera)
        rightHand.SetActive(false); // disable our right hand
        rightHandRay.SetActive(false); // disable our right hand ray
        leftHand.SetActive(false); // disable our left hand
        leftHandRay.SetActive(false); // disable our our left hand ray
        RideTheTrainCameraEnable();
    }

    void ExitTheTrainVREnable()
    {
        vRRig.SetActive(true); // enable our VR rig camera (careful originally it was the whole rig, now only the main camera)
        rightHand.SetActive(true); // enable our right hand
        rightHandRay.SetActive(true); // enable our right hand ray
        leftHand.SetActive(true); // enable our left hand
        leftHandRay.SetActive(true); // enable our left hand ray
        playerRespawn.EnablePlayerRespawn(); // call the player respawn function from the player respawn script
    }

    void ExitTheTrainCameraDisable()
    {
        trainRideRigCamera.SetActive(false);
        ExitTheTrainVREnable();
    }

    void RideTheTrainCameraEnable()
    {
        Debug.Log("Train ride rig camera");
        trainRideRigCamera.SetActive(true);
    }
}
