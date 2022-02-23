using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    public LayerMask mask;
    public float range;
    public float angle;    
    private void Update()
    {
        if (IsInSight(playerPos))
        {
            MoveTowards();
        }
    }
    public bool IsInSight(Transform target)
    {
        //resto los dos puntos para tener la distancia en la que se encuentra y saber si esta dentro o fuera del rango.
        Vector3 diff = (target.position - transform.position);
        float distance = diff.magnitude;
        if (distance > range) return false;
        //angulo entre mi frente y la direccion hacia el objetivo
        float angleToTarget = Vector3.Angle(transform.forward, diff.normalized);
        if (angleToTarget > angle / 2) return false;
        if (Physics.Raycast(transform.position, diff.normalized, distance, mask))
        {
            return false;
        }
        return true;
    }
    private void OnDrawGizmosSelected()
    {
        //Para ver los rangos y donde apunta la camara.
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, transform.forward * range);
        Gizmos.DrawWireSphere(transform.position, range);
        Gizmos.DrawRay(transform.position, Quaternion.Euler(0, angle / 2, 0) * transform.forward * range);
        Gizmos.DrawRay(transform.position, Quaternion.Euler(0, -angle / 2, 0) * transform.forward * range);
    }
}

