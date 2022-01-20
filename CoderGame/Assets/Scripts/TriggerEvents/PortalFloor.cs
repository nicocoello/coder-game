using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalFloor : MonoBehaviour
{
    [SerializeField] private Transform destinationPortal;
    [SerializeField] private Transform playerPos;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerPos.transform.position = destinationPortal.transform.position;
        }
    }
}
