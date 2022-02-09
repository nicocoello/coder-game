using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DeathFloor : MonoBehaviour
{
    [SerializeField] private Transform _checkPoint;
    [SerializeField] private Transform _playerPos;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _playerPos.transform.position = _checkPoint.transform.position;
        }
    }
   
}
