using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTrain : MonoBehaviour
{

    public Transform startPos; // reference to the starting position transform fo rthe train
    public bool firstTimeTrainReset; // bool for if the train has been reset before or not

    /// <summary>
    /// Reset the train and make it's current target 
    /// the transform set in the editor (Train station edge transform)
    /// </summary>
    public void ResetTrainPrefab()
    {
        gameObject.transform.position = startPos.transform.position; // set the trains transform position to the starting position transform's position
        gameObject.transform.rotation = startPos.transform.rotation; // set the trains transform rotation to the starting position transform's rotation
        firstTimeTrainReset = true; // set the first time train reset bool to true
    }
}
