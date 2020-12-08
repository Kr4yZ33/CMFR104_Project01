using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour
{
   // Update is called once per frame
    void Update()
    {
        var currentPos = transform.position;
        transform.position = Vector3(Mathf.Round(currentPos.x),
                                     Mathf.Round(currentPos.y),
                                     Mathf.Round(currentPos.z));
    }

    private Vector3 Vector3(float v1, float v2, float v3)
    {
        throw new NotImplementedException();
    }
}
