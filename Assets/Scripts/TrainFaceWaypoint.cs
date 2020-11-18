using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This complete script can be attached to a camera to make it
// continuously point at another object.

public class TrainFaceWaypoint : MonoBehaviour
{
    public TrainController trainController;
    
    public Transform target;
    

    void Update()
    {
        target = trainController.currentTarget;
        if (trainController.trainMeshFaceNextWaypoint == true)
        {
            // Rotate the camera every frame so it keeps looking at the target
            transform.LookAt(target);

            // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
            //transform.LookAt(target, Vector3.left);
        }
    }
}
