using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialSpawn : MonoBehaviour
{
    private Transform _initialPoint;
    private GameObject _character;

    private void Start()
    {
        _character = GameObject.FindGameObjectWithTag("Player");
        _initialPoint = GameObject.FindGameObjectWithTag("Spawn").transform;
        Spawn();
    }
    void Spawn()
    {
        _character.transform.position = _initialPoint.position;
    }
}
