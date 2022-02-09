using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryFloor : MonoBehaviour
{
    GameManager _gm;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _gm.Victory();
        }
    }
}
