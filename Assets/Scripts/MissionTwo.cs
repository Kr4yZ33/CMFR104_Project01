using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTwo : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject transparentTree;
    public GameObject missionTwoUI;
    public GameObject uIButtonDisplay;

    public AudioClip missionSuccessful;
    public AudioSource audioSource;
    public float volume = 0.5f;


    public void MissionTwoComplete()
    {
        transparentTree.SetActive(false);
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.secondMissionComplete = true;
        gameManager.secondMissonInProgress = false;
        missionTwoUI.SetActive(false);
    }

    public void DisplyMissionTwo()
    {
        if (gameManager.secondMissonInProgress == true)
        {
            missionTwoUI.SetActive(true);
            uIButtonDisplay.SetActive(false);
        }
    }
}
