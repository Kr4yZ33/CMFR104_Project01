using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionThree : MonoBehaviour
{
    public GameManager gameManager;
    public TrainExitTile trainExitTile;

    public GameObject missionThreeUI;
    public GameObject uIButtonDisplay;
    public GameObject missionParent;

    public AudioClip missionSuccessful;
    public AudioSource audioSource;
    public float volume = 0.5f;

    private void FixedUpdate()
    {
        if(gameManager.thirdMissonComplete == true)
        {
            return;
        }
        
        if(trainExitTile.ridingTrain == true)
        {
            MissionThreeComplete();
        }
    }

    public void StartMissionThree()
    {
        gameManager.thirdMissonInProgress = true;
        missionThreeUI.SetActive(true);
    }

    public void MissionThreeComplete()
    {
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.thirdMissonComplete = true;
        gameManager.thirdMissonInProgress = false;
        missionThreeUI.SetActive(false);
        uIButtonDisplay.SetActive(true);
    }

    public void DisplyMissionThree()
    {
        if (gameManager.thirdMissonInProgress == true)
        {
            missionParent.SetActive(true);
            missionThreeUI.SetActive(true);
            uIButtonDisplay.SetActive(false);
        }
    }
}
