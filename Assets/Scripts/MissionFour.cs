using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionFour : MonoBehaviour
{
    public GameManager gameManager; // reference to the Game Manager
    public ResetTrain resetTrain;
    public HoverChangeUIButtons hoverChangeUIButtons; // reference to the hoverchange UI buttons script (changes the colour of the button lights)

    public GameObject missionFourUI; // reference to the mission four UI instruction card
    public GameObject uIButtonDisplay; // reference to the UI button control guide card
    public GameObject missionParent; // reference to the parent object the mission UI cards are on
    public GameObject makingOfUiDisplay; // reference to the parent the gallery behind the huge train so the gallery and the cars can be disabled and re-enabled
    public GameObject missionThreeButtonLight; // reference to the button light for mission three
    public GameObject missionFourButtonLight; // reference to the button light for mission four

    public AudioClip missionSuccessful; // reference to the audio clip that plays when a mission is successful
    public AudioSource audioSource; // reference to the audiosource
    public float volume = 0.5f; // float for the volume of the audio clip

    // fixed update runs once every 60 frames
    private void FixedUpdate()
    {
        if (gameManager.fourthMissonComplete == true) // if the fourth mission complete bool is tru on the game manager script
        {
            return; // exit
        }

        if(resetTrain.firstTimeTrainReset == true) // if the bool for first time train reset is true on the resent train script
        {
            MissionFourComplete(); // call the function for mission four complete
        }
    }

    /// <summary>
    /// public function called to start mission four
    /// </summary>
    public void StartMissionFour()
    {
        missionFourButtonLight.SetActive(true); // enable the mission four button light
        gameManager.fourthMissonInProgress = true;  // set the bool for fourth misison in progress to true on the game manager script
        missionFourUI.SetActive(true); // enable the mission for UI card
        if(gameManager.skipTrainingMissionns == true)  // if the skip training mission bool on the game mamaner script is true
        {
            MissionFourComplete(); // call the mission four complete function
            hoverChangeUIButtons.MakeGreen(); // call the make green function on the hove change ui botton script (attached to the button light)
        }
    }
    /// <summary>
    /// public function called to complete mission four
    /// </summary>
    public void MissionFourComplete()
    {
        makingOfUiDisplay.SetActive(true); // enable the parent that holds the gallery UI
        uIButtonDisplay.SetActive(true); // enable the UIcontroller card
        audioSource.PlayOneShot(missionSuccessful); // play the mission successful audio clip as a play one shot
        gameManager.fourthMissonComplete = true;  // set the bool for fourth mission complete to true on the game manager script
        gameManager.fourthMissonInProgress = false; // set the bool for fourth mission in progress to false on the game manager script
        missionFourUI.SetActive(false); // disable the UI card for mission four
        missionParent.SetActive(false); // enable the mission parent game object
        hoverChangeUIButtons.MakeGreen();  // call the function to make the object gree from the hover change UI button script
    }

    /// <summary>
    /// public function called via tablet UI buttons
    /// used to display mission four again if the UI control guide has been displayed
    /// </summary>
    public void DisplyMissionFour()
    {
        if (gameManager.fourthMissonInProgress == true) // if the fourth mission in progress bool on the game manager script is true
        {
            missionParent.SetActive(true);// enable the mission parent game object
            missionFourUI.SetActive(true); // enable the mission four UI card (which is a child of the mission parent)
            uIButtonDisplay.SetActive(false);  // disable the ui button control guide
        }
    }
}
