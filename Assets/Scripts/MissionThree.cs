using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionThree : MonoBehaviour
{
    public GameManager gameManager;
    public TrainExitTile trainExitTile;
    public MissionFour missionFour;
    public HoverChangeUIButtons hoverChangeUIButtons;

    public GameObject missionThreeUI;
    public GameObject uIButtonDisplay;
    public GameObject missionParent;
    public GameObject missionTwoButtonLight;
    public GameObject missionThreeButtonLight;

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
        missionTwoButtonLight.SetActive(false);
        missionThreeButtonLight.SetActive(true);
        gameManager.thirdMissonInProgress = true;
        missionThreeUI.SetActive(true);
    }

    public void MissionThreeComplete()
    {
        audioSource.PlayOneShot(missionSuccessful);
        gameManager.thirdMissonComplete = true;
        gameManager.thirdMissonInProgress = false;
        missionThreeUI.SetActive(false);
        hoverChangeUIButtons.MakeGreen();
        missionFour.StartMissionFour();
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
