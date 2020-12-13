using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionOne : MonoBehaviour
{
    public GameManager gameManager;
    public MissionTwo missionTwo;
    public HoverChangeUIButtons hoverChangeUIButtons;

    public GameObject transparentTrack;
    public GameObject missionOneUI;
    public GameObject uIButtonDisplay;
    public GameObject missionParent;
    public GameObject trainTrackMovementSoundAudioSource;
    public GameObject missionOneButtonLight;

    public AudioClip missionSuccessful;
    public AudioSource audioSource;
    public float volume = 0.5f;


    public void StartMissionOne()
    {
        gameManager.startMissonInProgress = true;
        transparentTrack.SetActive(true);
        DisplyMissionOne();
        missionOneButtonLight.SetActive(true);
    }

    public void MissionOneComplete()
    {
        transparentTrack.SetActive(false);
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.startMissionComplete = true;
        gameManager.startMissonInProgress = false;
        missionOneUI.SetActive(false);
        trainTrackMovementSoundAudioSource.SetActive(true);
        missionOneButtonLight.SetActive(false);
        missionTwo.StartMissionTwo();
        
    }

    public void DisplyMissionOne()
    {
        if(gameManager.startMissonInProgress == true)
        {
            missionParent.SetActive(true);
            missionOneUI.SetActive(true);
            uIButtonDisplay.SetActive(false);
        }
    }
}
