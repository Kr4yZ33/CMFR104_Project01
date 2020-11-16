using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSnapConnection : MonoBehaviour
{
    public Transform closestEdge;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TrackEdge"))
        {
            closestEdge = other.gameObject.transform;
        }
    }
}
