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

    public void SkipTrainingMissions()
    {
        startMissionComplete = true;
        secondMissionComplete = true;
        thirdMissonComplete = true;
    }
}
