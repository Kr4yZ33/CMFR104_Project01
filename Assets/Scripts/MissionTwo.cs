using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTwo : MonoBehaviour
{
    public GameManager gameManager; // reference to the Game Manager
    public MissionThree missionThree;
    public HoverChangeUIButtons hoverChangeUIButtons; // reference to the hoverchange UI buttons script (changes the colour of the button lights)

    public GameObject transparentTree;  // reference to the transparent guide tree
    public GameObject missionTwoUI; // reference to the mission two UI instruction card
    public GameObject uIButtonDisplay; // reference to the UI button control guide card
    public GameObject missionParent; // reference to the parent object the mission UI cards are on
    public GameObject missionOneButtonLight; // reference to the button light for mission one
    public GameObject missionTwoButtonLight; // reference to the button light for mission two

    public AudioClip missionSuccessful; // reference to the audio clip that plays when a mission is successful
    public AudioSource audioSource; // reference to the audiosource
    public float volume = 0.5f; // float for the volume of the audio clip


    /// <summary>
    /// public function to call the start of mission two
    /// </summary>
    public void StartMissionTwo()
    {
        missionTwoButtonLight.SetActive(true); // enable the mission two button light
        gameManager.secondMissonInProgress = true;  // set the bool for second misison in progress to true on the game manager script
        missionTwoUI.SetActive(true); // enable the mission two UI card
        transparentTree.SetActive(true); // enable the transparent tree 
        if(gameManager.skipTrainingMissionns == true) // if the skip training mission bool on the game mamaner script is true
        {
            MissionTwoComplete(); // call the mission two complete function
        }
    }

    public void MissionTwoComplete()
    {
        transparentTree.SetActive(false);
        audioSource.PlayOneShot(missionSuccessful); // play the mission successful audio clip as a play one shot
        gameManager.secondMissionComplete = true;  // set the bool for second mission complete to true on the game manager script
        gameManager.secondMissonInProgress = false; // set the bool for second mission in progress to false on the game manager script
        missionTwoUI.SetActive(false);  // disable the UI card for mission two
        missionTwoButtonLight.SetActive(false);  // disable the mission two button light
        missionThree.StartMissionThree(); // call the function for starting mission three from the mission three script
    }

    /// <summary>
    /// public function called via tablet UI buttons
    /// used to display mission two again if the UI control guide has been displayed
    /// </summary>
    public void DisplyMissionTwo()
    {
        if (gameManager.secondMissonInProgress == true) // if the second mission in progress bool on the game manager script is true
        {
            missionParent.SetActive(true); // enable the mission parent game object
            missionTwoUI.SetActive(true); // enable the mission two UI card (which is a child of the mission parent)
            uIButtonDisplay.SetActive(false);  // disable the ui button control guide
        }
    }
}
