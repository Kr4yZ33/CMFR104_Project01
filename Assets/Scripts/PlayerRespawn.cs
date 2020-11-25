using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform playerRespawnTransform; // reference to the transform the player respawns to

    void OnTriggerEnter(Collider other) // on trigger entre
    {
        if(other.gameObject.CompareTag("Respawn")) // if the thing colliding with us has the tag Respawn
        {
            gameObject.transform.position = playerRespawnTransform.transform.position; // set the transform of the object this script is attached to to the player respawn transform position
            gameObject.transform.rotation = playerRespawnTransform.transform.rotation; // set the transform of the object this script is attached to to the player respawn transform rotation
        }
    }
}
