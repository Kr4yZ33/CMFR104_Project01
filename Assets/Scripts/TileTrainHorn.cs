using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTrainHorn : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other) // On trigger enter
    {
        TrainController script = other.gameObject.GetComponent<TrainController>();

        script.trainHorn = true;
    }
}
