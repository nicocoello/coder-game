using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupWin : MonoBehaviour
{
    private GameManager _gm;
    private void Start()
    {
        _gm = GameManager.FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _gm.Victory();
        }
    }
}
