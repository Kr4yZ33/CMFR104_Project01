using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    public bool trainHeld;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trainHeld = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            trainHeld = false;
        }
    }
}
