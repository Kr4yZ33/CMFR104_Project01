using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingBeltScript : MonoBehaviour
{  
    public GameObject playerBeltTransform;  // The transform the tablet attaches to
    public GameObject belt; // reference to the belt game object

    public bool isHeld; // A bool for if the tablet is being held or not
    
    // Start is called before the first frame update
    void Start()
    {
        belt.transform.position = playerBeltTransform.transform.position; // sync the belt and player belt transform positions to be the same (make the tablet appear at that transform)
        belt.transform.rotation = playerBeltTransform.transform.rotation; // sync the belt and player belt transform rotation to be the same (make the tablet appear at that transform)
    }

    // Update is called once per frame
    void Update()
    {
        if(isHeld != true) // if the tablet is not being held
        {
            belt.transform.position = playerBeltTransform.transform.position; // sync the belt and player belt transform positions to be the same (make the tablet appear at that transform)
            belt.transform.rotation = playerBeltTransform.transform.rotation; // sync the belt and player belt transform rotation to be the same (make the tablet appear at that transform)
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("LeftHand")) // on trigger start with an object tagged Player
        {
            isHeld = true; // set the isHeld bool to true
        }
        if (other.gameObject.CompareTag("RightHand")) // on trigger start with an object tagged Player
        {
            isHeld = true; // set the isHeld bool to true
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("LeftHand")) // on trigger exit with an object tagged Player
        {
            isHeld = false; // set the isHeld bool to false
        }
        if (other.gameObject.CompareTag("RightHand")) // on trigger exit with an object tagged Player
        {
            isHeld = false; // set the isHeld bool to false
        }
    }
}
