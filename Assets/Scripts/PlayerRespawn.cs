using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform playerRespawnTransform;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = playerRespawnTransform.transform.position;
            other.gameObject.transform.rotation = playerRespawnTransform.transform.rotation;
        }
    }
}
