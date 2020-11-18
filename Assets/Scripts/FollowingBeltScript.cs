using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingBeltScript : MonoBehaviour
{
    public GameObject playerBeltTransform;
    public GameObject belt;

    public bool isHeld;
    
    // Start is called before the first frame update
    void Start()
    {
        belt.transform.position = playerBeltTransform.transform.position;
        belt.transform.rotation = playerBeltTransform.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(isHeld != true)
        {
            belt.transform.position = playerBeltTransform.transform.position;
            belt.transform.rotation = playerBeltTransform.transform.rotation;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isHeld = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isHeld = false;
        }
    }
}
