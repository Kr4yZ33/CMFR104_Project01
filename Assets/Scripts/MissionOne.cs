﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionOne : MonoBehaviour
{
    public GameManager gameManager;
    public MissionTwo missionTwo;

    public GameObject transparentTrack;
    public GameObject missionOneUI;
    public GameObject uIButtonDisplay;
    public GameObject missionParent;
    public GameObject trainTrackMovementSoundAudioSource;

    public AudioClip missionSuccessful;
    public AudioSource audioSource;
    public float volume = 0.5f;


    public void StartMissionOne()
    {
        gameManager.startMissonInProgress = true;
        transparentTrack.SetActive(true);
        DisplyMissionOne();
    }

    public void MissionOneComplete()
    {
        transparentTrack.SetActive(false);
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.startMissionComplete = true;
        gameManager.startMissonInProgress = false;
        missionOneUI.SetActive(false);
        missionTwo.StartMissionTwo();
        trainTrackMovementSoundAudioSource.SetActive(true);
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
