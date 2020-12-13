using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTwoTrigger : MonoBehaviour
{
    public MissionTwo missionTwo; // reference to the Mission Two script
    
    /// <summary>
    /// on trigger enter
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TreeSpawn")) // if thie thing colliding with us is tagged TreeSPawn
        {
            missionTwo.MissionTwoComplete(); // call the function for mission two complete from the mission two script
        }
    }
}
