using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool startMissionComplete;
    public bool startMissonInProgress = true;
    public bool secondMissionComplete;
    public bool secondMissonInProgress;
    public bool thirdMissonComplete;
    public bool thirdMissonInProgress;


    void FixedUpdate()
    {
        if(startMissionComplete == true && secondMissionComplete != true)
        {
            StartSecondMission();
        }
    }

    public void SkipTrainingMissions()
    {
        startMissionComplete = true;
        secondMissionComplete = true;
        thirdMissonComplete = true;
    }

    void StartSecondMission()
    {

    }
}
