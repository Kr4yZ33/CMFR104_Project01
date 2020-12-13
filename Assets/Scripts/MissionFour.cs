using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionFour : MonoBehaviour
{
    public GameManager gameManager;
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
        missionThreeButtonLight.SetActive(false);
        missionFourButtonLight.SetActive(true);
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
        hoverChangeUIButtons.MakeGreen();
        uIButtonDisplay.SetActive(true);
        makingOfUiDisplay.SetActive(true);
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
