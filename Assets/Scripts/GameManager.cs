using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MissionFour missionFour; // reference to the mission four script
    public MissionThree missionThree; // reference to the mission three script
    public MissionTwo missionTwo; // reference to the mission two script
    public MissionOne missionOne; // reference to the mission one script

    public bool startMissionComplete; // bool for is the start mission has been completed
    public bool startMissonInProgress; // bool for is the start mission is in progress
    public bool secondMissionComplete; // bool for is the second mission has been completed
    public bool secondMissonInProgress; // bool for is the second mission is in progress
    public bool thirdMissonComplete; // bool for is the third mission has been completed
    public bool thirdMissonInProgress; // bool for is the thrid mission is in progress
    public bool fourthMissonComplete; // bool for is the fourth mission has been completed
    public bool fourthMissonInProgress; // bool for is the fourth mission is in progress
    public bool skipTrainingMissionns; // bool for if the skip training missions button has been pressed


    public GameObject missionOneQuickClear; // reference to the piece of track used to fill the gap in mission one where the transparent track is
    public GameObject transparentTrack;  //reference to the transparent guide track
    public GameObject transparentTree; // reference to the transparent guide tree
    public GameObject trainTrackMovementSoundAudioSource; // reference to the object on the train that has the audio source, when enabled this allows the train to play the sound moving over train tracks

    /// <summary>
    /// public function for skipping training mission
    /// called via tablet UI buttons
    /// </summary>
    public void SkipTrainingMissions()
    {
        skipTrainingMissionns = true; // if the bool for skip training mission is true
        if(startMissionComplete != true) // is the bool for start mission complete is not true
        {
            missionOneQuickClear.SetActive(true); // enable the track piece to fill the mission one gap
            missionOne.StartMissionOne(); // call the start mission one function from the mission one script
        }
        else // otherwise
        {
            missionTwo.StartMissionTwo(); // call the start mission two function from the mission two script
        }
    }
}
