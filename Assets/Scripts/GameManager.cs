using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MissionFour missionFour;
    public MissionThree missionThree;
    public MissionTwo missionTwo;
    public MissionOne missionOne;

    public bool startMissionComplete;
    public bool startMissonInProgress;
    public bool secondMissionComplete;
    public bool secondMissonInProgress;
    public bool thirdMissonComplete;
    public bool thirdMissonInProgress;
    public bool fourthMissonComplete;
    public bool fourthMissonInProgress;
    public bool skipTrainingMissionns;


    public GameObject missionOneQuickClear;
    public GameObject transparentTrack;
    public GameObject transparentTree;
    public GameObject trainTrackMovementSoundAudioSource;

    public void SkipTrainingMissions()
    {
        skipTrainingMissionns = true;
        if(startMissionComplete != true)
        {
            missionOneQuickClear.SetActive(true);
            missionOne.StartMissionOne();
        }
        else
        {
            missionTwo.StartMissionTwo();
        }
    }
}
