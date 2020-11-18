using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This complete script can be attached to a camera to make it
// continuously point at another object.

public class TrainFaceWaypoint : MonoBehaviour
{
    public TrainController trainController;
    
    public Transform target;

    // Angular speed in radians per sec.
    public float speed = 1.0f;

    void Update()
    {
        if (trainController.trainMeshFaceNextWaypoint == true)
        {
            target = trainController.currentTarget;
            // Rotate the camera every frame so it keeps looking at the target
            // transform.LookAt(target);
            //transform.LookAt(target, Vector3.left);

            // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
            //transform.LookAt(target, Vector3.left);


            // Determine which direction to rotate towards
            Vector3 targetDirection = target.position - transform.position;

            // The step size is equal to speed times frame time.
            float singleStep = speed * Time.deltaTime;

            // Rotate the forward vector towards the target direction by one step
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

            // Draw a ray pointing at our target in
            Debug.DrawRay(transform.position, newDirection, Color.red);

            // Calculate a rotation a step closer to the target and applies rotation to this object
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}
