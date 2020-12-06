using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionOneTrigger : MonoBehaviour
{
    public MissionOne missionOne;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TrackMesh"))
        {
            missionOne.MissionOneComplete();
        }
    }
}
