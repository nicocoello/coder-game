using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    public float jumpForce;    
    public GameObject bullet;
    public Transform firePoint;
    Rigidbody _rb;
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    public void Move(Vector3 dir)
    {
        dir *= speed;
        dir.y = 0;
        transform.forward = dir;
        dir.y = _rb.velocity.y;
        _rb.velocity = dir;
    }
    public void Jump()
    {
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    public void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);        
    }
}
