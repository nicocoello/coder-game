using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] protected Transform playerPos;
    protected void MoveTowards()
    {
        float distance = Vector3.Distance(transform.position, playerPos.transform.position);
        if (distance >= 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPos.position, 5 * Time.deltaTime);
        }
    }
}
