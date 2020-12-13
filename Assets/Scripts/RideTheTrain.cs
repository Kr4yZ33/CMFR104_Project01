using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideTheTrain : MonoBehaviour
{
    public TrainExitTile trainExitTile; // Reference to the Train Exit Tile script

    /// <summary>
    /// on trigger enter
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (trainExitTile.ridingTrain == true) // if the bool for riding the train on the Train Exit Tile script is true
        {
            trainExitTile.passedStationWhileRidingTrain = true; // set the bool for passed station while riding train on the Train Exit tile script to true
        }

        if (trainExitTile.ridingTrain == true) // if the bool for riding the train on the train exit tile is true
        {
            return; // exit the script
        }

        if (other.CompareTag("Train") && trainExitTile.trainExitTilePlaced == true && trainExitTile.buildPlatformInRange == true) // if the thing colliding with us has the tag train & the bool for train exit tile placed on the train exit tile script is true & the bool for the build platform being in range of the train exit tile is true
        {
            trainExitTile.RideTheTrain(); // call the function for riding the train from the train exit tile.
        }
    }  
}