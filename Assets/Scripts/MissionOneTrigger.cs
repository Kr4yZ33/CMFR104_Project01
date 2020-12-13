using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionOneTrigger : MonoBehaviour
{
    public MissionOne missionOne; // reference to our MIssion one script
    
    /// <summary>
    ///  on trigger enter
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TrackMesh")) // if the thing colliding with us is tagged TrackMesh
        {
            missionOne.MissionOneComplete(); // call the function for mission one complete from the mission one script
        }
    }
}
