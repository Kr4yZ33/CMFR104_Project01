using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTrain : MonoBehaviour
{

    public Transform startPos; // reference to the starting position transform fo rthe train
    public GameObject train; // reference to the train

    /// <summary>
    /// Reset the train and make it's current target 
    /// the transform set in the editor (Train station edge transform)
    /// </summary>
    public void ResetTrainPrefab()
    {
        train.transform.position = startPos.transform.position; // set the trains transform position to the starting position transform's position
        train.transform.rotation = startPos.transform.rotation; // set the trains transform rotation to the starting position transform's rotation
        train.SetActive(false); // disable the train parent and all childs
        train.SetActive(true); // re-enable the train parent and all childs
    }
}
