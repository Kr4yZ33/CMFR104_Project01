using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionOneTrigger : MonoBehaviour
{
    public MissionOne missionOne;
    private void OnTriggerEnter(Collider other)
    {
        HapticsController script = other.gameObject.GetComponent<HapticsController>();

        if (other.CompareTag("TrackMesh") && script.isHeld != true)
        {
            missionOne.MissionOneComplete();
        }
    }
}
