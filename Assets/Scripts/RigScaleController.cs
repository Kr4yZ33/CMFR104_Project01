using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigScaleController : MonoBehaviour
{
    public GameObject smallScaleRig;
    public GameObject smallScaleRigBelt;
    public GameObject largeScaleRig;
    public GameObject largeScaleRigBelt;
    public BoxCollider buildPlatformCollider;
    

    public void ChangeScaleToSmall()
    {
        largeScaleRig.SetActive(false);
        largeScaleRigBelt.SetActive(false);
        //gameObject.transform.localScale = new Vector3(1, 1, 1);
        buildPlatformCollider.enabled = true;
        smallScaleRig.SetActive(true);
        smallScaleRigBelt.SetActive(true);
        //gameObject.transform.position = smallRigSpawnTransform.transform.position;
    }

    public void ChangeScaleToLarge()
    {
        smallScaleRig.SetActive(false);
        smallScaleRigBelt.SetActive(false);
        //gameObject.transform.localScale = new Vector3(10, 10, 10);
        //gameObject.transform.position = largeRigSpawnTransform.position;
        //gameObject.transform.rotation = largeRigSpawnTransform.rotation;
        buildPlatformCollider.enabled = false;
        largeScaleRig.SetActive(true);
        largeScaleRigBelt.SetActive(true);
    }

    //public void IncreaseSCalebyOne()
    //{
        //gameObject.transform.localScale += new Vector3(1, 1, 1);
    //}

    //public void DecreaseSCalebyOne()
    //{
        //gameObject.transform.localScale += new Vector3(-1, -1, -1);
    //}
}