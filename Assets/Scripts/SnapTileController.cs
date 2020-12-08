using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapTileController : MonoBehaviour
{
    public bool objectInRange;

    private void OnTriggerStay(Collider other)
    {
        HapticsController script = other.gameObject.GetComponent<HapticsController>();

        if (script.isHeld != true)
        {
            script.SnapObjectToGrid();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 18)
        {
            HapticsController script = other.gameObject.GetComponent<HapticsController>();

            objectInRange = true;
            script.gradSnapTransform = gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 18)
        {
            objectInRange = false;
        }
    }
}
