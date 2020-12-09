using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionFour : MonoBehaviour
{
    public GameManager gameManager;
    public ResetTrain resetTrain;

    public GameObject missionFourUI;
    public GameObject uIButtonDisplay;
    public GameObject missionParent;

    public AudioClip missionSuccessful;
    public AudioSource audioSource;
    public float volume = 0.5f;

    private void FixedUpdate()
    {
        if (gameManager.fourthMissonComplete == true)
        {
            return;
        }

        if(resetTrain.firstTimeTrainReset == true)
        {
            MissionFourComplete();
        }
    }

    public void StartMissionFour()
    {
        gameManager.fourthMissonInProgress = true;
        missionFourUI.SetActive(true);
    }

    public void MissionFourComplete()
    {
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.fourthMissonComplete = true;
        gameManager.fourthMissonInProgress = false;
        missionFourUI.SetActive(false);
        missionParent.SetActive(false);
        uIButtonDisplay.SetActive(true);
    }

    public void DisplyMissionFour()
    {
        if (gameManager.fourthMissonInProgress == true)
        {
            missionParent.SetActive(true);
            missionFourUI.SetActive(true);
            uIButtonDisplay.SetActive(false);
        }
    }
}
