using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionOne : MonoBehaviour
{
    public GameManager gameManager; // reference to the Game Manager
    public MissionTwo missionTwo; // reference to the mission two script

    public GameObject transparentTrack; //reference to the transparent guide track
    public GameObject missionOneUI; // reference to the mission one UI instruction card
    public GameObject uIButtonDisplay; // reference to the UI button control guide card
    public GameObject missionParent; // reference to the parent object the mission UI cards are on
    public GameObject trainTrackMovementSoundAudioSource; // reference to the audiosource for the train movement sound.
    public GameObject missionOneButtonLight;  // reference to the button light for mission one

    public AudioClip missionSuccessful; // reference to the audio clip that plays when a mission is successful
    public AudioSource audioSource; // reference to the audiosource
    public float volume = 0.5f; // float for the volume of the audio clip


    /// <summary>
    /// public function that starts mission one
    /// </summary>
    public void StartMissionOne()
    {
        gameManager.startMissonInProgress = true; // set the bool for start misison in progress to true on the game manager script
        transparentTrack.SetActive(true); // enable the transparent track piece
        DisplyMissionOne(); // call the function to display the mission one card
        missionOneButtonLight.SetActive(true); // enable the mission one button light
    }

    /// <summary>
    /// public function called to complete mission one
    /// </summary>
    public void MissionOneComplete()
    {
        transparentTrack.SetActive(false); // disable the transparent track piece
        audioSource.PlayOneShot(missionSuccessful); // play the mission successful audio clip as a play one shot
        gameManager.startMissionComplete = true; // set the bool for start mission complete to true on the game manager script
        gameManager.startMissonInProgress = false; // set the bool for start mission in progress to false on the game manager script
        missionOneUI.SetActive(false); // disable the UI card for mission one
        trainTrackMovementSoundAudioSource.SetActive(true); // enable the game object on the train with the train audio source on it
        missionOneButtonLight.SetActive(false); // disable the mission one button light
        missionTwo.StartMissionTwo(); // call the function for starting mission two from the mission two script
        
    }

    /// <summary>
    /// public function called via tablet UI buttons
    /// used to display mission one again if the UI control guide has been displayed
    /// </summary>
    public void DisplyMissionOne()
    {
        if(gameManager.startMissonInProgress == true) // if the start mission in progress bool on the game manager script is true
        {
            missionParent.SetActive(true); // enable the mission parent game object
            missionOneUI.SetActive(true); // enable the m ission one UI card (which is a child of the mission parent)
            uIButtonDisplay.SetActive(false); // disable the ui button control guide
        }
    }
}
