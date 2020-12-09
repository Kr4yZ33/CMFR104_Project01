using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionFour : MonoBehaviour
{
    public GameManager gameManager;
    public TrainController trainController;

    public GameObject missionFourUI;
    public GameObject uIButtonDisplay;
    public GameObject missionParent;

    public AudioClip missionSuccessful;
    public AudioSource audioSource;
    public float volume = 0.5f;

    public bool missionStageOneComplete;
    public bool missionStageTwoComplete;

    private void FixedUpdate()
    {
        if (gameManager.fourthMissonComplete == true)
        {
            return;
        }

        if(missionStageTwoComplete == true)
        {
            return;
        }

        if(trainController.trainPassedTrainStationTrackTwo == true)
        {
            missionStageOneComplete = true;
        }

        if(missionStageOneComplete == true && trainController.trainPassedTrainStationTrackOne == true)
        {
            missionStageTwoComplete = true;
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
