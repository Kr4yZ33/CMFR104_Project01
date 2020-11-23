using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigScaleController : MonoBehaviour
{
    public Transform largeRigSpawnTransform;
    public Transform smallRigSpawnTransform;
    public GameObject buildPlatformCollider;

    public void ChangeScaleToSmall()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
        buildPlatformCollider.SetActive(true);
        gameObject.transform.position = smallRigSpawnTransform.transform.position;
    }

    public void ChangeScaleToLarge()
    {
        gameObject.transform.localScale = new Vector3(10, 10, 10);
        gameObject.transform.position = largeRigSpawnTransform.position;
        gameObject.transform.rotation = largeRigSpawnTransform.rotation;
        buildPlatformCollider.SetActive(false);
    }

    public void IncreaseSCalebyOne()
    {
        gameObject.transform.localScale += new Vector3(1, 1, 1);
    }

    public void DecreaseSCalebyOne()
    {
        gameObject.transform.localScale += new Vector3(-1, -1, -1);
    }
}