using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTwoTrigger : MonoBehaviour
{
    public MissionTwo missionTwo;
    private void OnTriggerEnter(Collider other)
    {
        HapticsController script = other.gameObject.GetComponent<HapticsController>();

        if (other.CompareTag("TreeSpawn") && script.isHeld != true)
        {
            missionTwo.MissionTwoComplete();
        }
    }
}
