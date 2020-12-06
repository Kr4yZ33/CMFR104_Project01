using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionOne : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject transparentTrack;
    public GameObject missionOneUI;
    public GameObject uIButtonDisplay;

    public AudioClip missionSuccessful;
    public AudioSource audioSource;
    public float volume = 0.5f;

    
    public void MissionOneComplete()
    {
        transparentTrack.SetActive(false);
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.startMissionComplete = true;
        gameManager.startMissonInProgress = false;
        missionOneUI.SetActive(false);
    }

    public void DisplyMissionOne()
    {
        if(gameManager.startMissonInProgress == true)
        {
            missionOneUI.SetActive(true);
            uIButtonDisplay.SetActive(false);
        }
    }
}
