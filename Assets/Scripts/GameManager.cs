using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MissionFour missionFour;

    public bool startMissionComplete;
    public bool startMissonInProgress;
    public bool secondMissionComplete;
    public bool secondMissonInProgress;
    public bool thirdMissonComplete;
    public bool thirdMissonInProgress;
    public bool fourthMissonComplete;
    public bool fourthMissonInProgress;


    public GameObject missionOneQuickClear;
    public GameObject transparentTrack;

    public void SkipTrainingMissions()
    {
        transparentTrack.SetActive(false);
        missionOneQuickClear.SetActive(true);
        startMissionComplete = true;
        secondMissionComplete = true;
        thirdMissonComplete = true;
        missionFour.MissionFourComplete();
    }
}
