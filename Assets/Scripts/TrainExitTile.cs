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
    }
}
