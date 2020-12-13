using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseCentreWaypointController : MonoBehaviour
{
    public Transform reverseEdge; // reference to the reverse edge transform
    public Transform centre; // reference to the centre transform
    public bool trainPassingTransform; // bool for if the train is passing the game objects transform

    /// <summary>
    /// on trigger enter
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true) // if the bool for train passing transform is true
        {
            return; // exit the script

        }
        if (other.CompareTag("Train")) // if the object colliding with us is tagged Train
        {

            TrainController script = other.gameObject.GetComponent<TrainController>(); // access the game object and get the train controller script from it (saves us having to assign manually)

            script.previousTarget = centre; // set the previous target on the train controller script to the centre transform
            script.currentTarget = reverseEdge; // set the current target on the train controller script to the reverse edge transform of the track tile
            trainPassingTransform = true; // set the train passing transform bool to true

        }
    }

    /// <summary>
    /// on trigger exit
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Train")) // if the thing leaving out collider is tagged Train
        {
            trainPassingTransform = false; // set the train passing bool transfor to false
        }
    }
}
