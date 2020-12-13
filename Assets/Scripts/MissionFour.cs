using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionFour : MonoBehaviour
{
    public GameManager gameManager; // reference to the Game Manager
    public ResetTrain resetTrain;
    public HoverChangeUIButtons hoverChangeUIButtons;

    public GameObject missionFourUI;
    public GameObject uIButtonDisplay;
    public GameObject missionParent;
    public GameObject makingOfUiDisplay;
    public GameObject missionThreeButtonLight;
    public GameObject missionFourButtonLight;

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
        missionFourButtonLight.SetActive(true);
        gameManager.fourthMissonInProgress = true;
        missionFourUI.SetActive(true);
        if(gameManager.skipTrainingMissionns == true)
        {
            MissionFourComplete();
            hoverChangeUIButtons.MakeGreen();
        }
    }

    public void MissionFourComplete()
    {
        makingOfUiDisplay.SetActive(true);
        uIButtonDisplay.SetActive(true);
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.fourthMissonComplete = true;
        gameManager.fourthMissonInProgress = false;
        missionFourUI.SetActive(false);
        missionParent.SetActive(false);
        hoverChangeUIButtons.MakeGreen();  
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
