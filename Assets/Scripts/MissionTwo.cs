﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTwo : MonoBehaviour
{
    public GameManager gameManager;
    public MissionThree missionThree;

    public GameObject transparentTree;
    public GameObject missionTwoUI;
    public GameObject uIButtonDisplay;
    public GameObject missionParent;

    public AudioClip missionSuccessful;
    public AudioSource audioSource;
    public float volume = 0.5f;


    public void StartMissionTwo()
    {
        gameManager.secondMissonInProgress = true;
        missionTwoUI.SetActive(true);
        transparentTree.SetActive(true);
    }

    public void MissionTwoComplete()
    {
        transparentTree.SetActive(false);
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.secondMissionComplete = true;
        gameManager.secondMissonInProgress = false;
        missionTwoUI.SetActive(false);
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
