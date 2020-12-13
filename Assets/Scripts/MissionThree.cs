using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionThree : MonoBehaviour
{
    public GameManager gameManager; // reference to the Game Manager
    public TrainExitTile trainExitTile;
    public MissionFour missionFour;
    public HoverChangeUIButtons hoverChangeUIButtons; // reference to the hoverchange UI buttons script (changes the colour of the button lights)

    public GameObject missionThreeUI; // reference to the mission three UI instruction card
    public GameObject uIButtonDisplay; // reference to the UI button control guide card
    public GameObject missionParent; // reference to the parent object the mission UI cards are on
    public GameObject missionTwoButtonLight; // reference to the button light for mission two
    public GameObject missionThreeButtonLight;  // reference to the button light for mission three

    public AudioClip missionSuccessful; // reference to the audio clip that plays when a mission is successful
    public AudioSource audioSource; // reference to the audiosource
    public float volume = 0.5f; // float for the volume of the audio clip

    // fixed update runs once every 60 frames
    private void FixedUpdate()
    {
        if(gameManager.thirdMissonComplete == true) // if the third mission complete bool is tru on the game manager script
        {
            return; // exit
        }
        
        if(trainExitTile.ridingTrain == true) // if the bool for riding the train is true form the train exit tile script
        {
            MissionThreeComplete(); // call the fucntion for mission three complete
        }
    }

    /// <summary>
    /// public function called to start mission three
    /// </summary>
    public void StartMissionThree()
    {
        missionThreeButtonLight.SetActive(true); // enable the mission three button light
        gameManager.thirdMissonInProgress = true;  // set the bool for thrid misison in progress to true on the game manager script
        missionThreeUI.SetActive(true);
        if(gameManager.skipTrainingMissionns == true)  // if the skip training mission bool on the game mamaner script is true
        {
            MissionThreeComplete(); // call the mission there complete function
        }
    }

    /// <summary>
    /// public function called to end mission three
    /// </summary>
    public void MissionThreeComplete()
    {
        audioSource.PlayOneShot(missionSuccessful); // play the mission successful audio clip as a play one shot
        gameManager.thirdMissonComplete = true; // set the bool for third mission complete to true on the game manager script
        gameManager.thirdMissonInProgress = false; // set the bool for third mission in progress to false on the game manager script
        missionThreeUI.SetActive(false); // disable the UI card for mission three
        missionThreeButtonLight.SetActive(false); // disable the mission three button light
        missionFour.StartMissionFour(); // call the function to start mission four from the mission four script
    }

    /// <summary>
    /// public function called via tablet UI buttons
    /// used to display mission three again if the UI control guide has been displayed
    /// </summary>
    public void DisplyMissionThree()
    {
        if (gameManager.thirdMissonInProgress == true) // if the third mission in progress bool on the game manager script is true
        {
            missionParent.SetActive(true); // enable the mission parent game object
            missionThreeUI.SetActive(true); // enable the mission three UI card (which is a child of the mission parent)
            uIButtonDisplay.SetActive(false);  // disable the ui button control guide
        }
    }
}
