using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTwo : MonoBehaviour
{
    public GameManager gameManager; // reference to the Game Manager
    public MissionThree missionThree;
    public HoverChangeUIButtons hoverChangeUIButtons;

    public GameObject transparentTree;
    public GameObject missionTwoUI;
    public GameObject uIButtonDisplay;
    public GameObject missionParent;
    public GameObject missionOneButtonLight;
    public GameObject missionTwoButtonLight;

    public AudioClip missionSuccessful;
    public AudioSource audioSource;
    public float volume = 0.5f;


    public void StartMissionTwo()
    {
        missionTwoButtonLight.SetActive(true);
        gameManager.secondMissonInProgress = true;
        missionTwoUI.SetActive(true);
        transparentTree.SetActive(true);
        if(gameManager.skipTrainingMissionns == true)
        {
            MissionTwoComplete();
        }
    }

    public void MissionTwoComplete()
    {
        transparentTree.SetActive(false);
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.secondMissionComplete = true;
        gameManager.secondMissonInProgress = false;
        missionTwoUI.SetActive(false);
        missionTwoButtonLight.SetActive(false);
        missionThree.StartMissionThree();
    }

    public void DisplyMissionTwo()
    {
        if (gameManager.secondMissonInProgress == true)
        {
            missionParent.SetActive(true);
            missionTwoUI.SetActive(true);
            uIButtonDisplay.SetActive(false);
        }
    }
}
