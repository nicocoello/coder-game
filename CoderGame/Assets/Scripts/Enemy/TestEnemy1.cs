using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy1 : MonoBehaviour
{
    [SerializeField]private Transform playerPos;
    private float _speedToRotate =5f;
       
    void Update()
    {
        LookAtPlayer();
    }
    public void LookAtPlayer()
    {
        Quaternion _newRotation = Quaternion.LookRotation(playerPos.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, _newRotation, _speedToRotate * Time.deltaTime);
    }
}
