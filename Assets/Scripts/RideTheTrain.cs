using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideTheTrain : MonoBehaviour
{
    public TrainExitTile trainExitTile;

    private void OnTriggerEnter(Collider other)
    {
        if (trainExitTile.ridingTrain == true)
        {
            trainExitTile.passedStationWhileRidingTrain = true;
        }

        if (trainExitTile.ridingTrain == true)
        {
            return;
        }

        if (other.CompareTag("Train") && trainExitTile.trainExitTilePlaced == true)
        {
            trainExitTile.RideTheTrain();
        }
    }
}