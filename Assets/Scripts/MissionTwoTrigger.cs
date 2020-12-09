using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTwoTrigger : MonoBehaviour
{
    public MissionTwo missionTwo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TreeSpawn"))
        {
            missionTwo.MissionTwoComplete();
        }
    }
}
