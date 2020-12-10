using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainExitTile : MonoBehaviour
{
    public PlayerRespawn playerRespawn;

    public AudioClip allABoard;
    public AudioSource audioSource;
    public float volume = 0.5f;

    public bool trainExitTilePlaced;
    public bool ridingTrain;
    public bool passedStationWhileRidingTrain;
    public bool buildPlatformInRange;

    public GameObject vRRig;
    public GameObject trainRideRig;

    public GameObject rightHand;
    public GameObject rightHandRay;
    public GameObject leftHand;
    public GameObject leftHandRay;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TilePlatform"))
        {
            buildPlatformInRange = true;
        }

        if (other.CompareTag("Train") && ridingTrain == true)
        {
            ExitTheTrain();
        }
        
        if(other.CompareTag("TrackMesh"))
        {
            trainExitTilePlaced = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TrackMesh"))
        {
            trainExitTilePlaced = false;
        }

        if (other.CompareTag("TilePlatform"))
        {
            buildPlatformInRange = false;
        }
    }

    public void RideTheTrain()
    {
        vRRig.SetActive(false);
        rightHand.SetActive(false);
        rightHandRay.SetActive(false);
        leftHand.SetActive(false);
        leftHandRay.SetActive(false);
        trainRideRig.SetActive(true);
        ridingTrain = true;
        audioSource.PlayOneShot(allABoard, volume);
    }

    void ExitTheTrain()
    {
        vRRig.SetActive(true);
        trainRideRig.SetActive(false);
        ridingTrain = false;
        passedStationWhileRidingTrain = false;
        playerRespawn.EnablePlayerRespawn();
        rightHand.SetActive(true);
        rightHandRay.SetActive(true);
        leftHand.SetActive(true);
        leftHandRay.SetActive(true);
    }
}
