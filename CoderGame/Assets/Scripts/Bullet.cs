using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float damage;
    Rigidbody _rb;    
    Vector3 _dir;
    

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();        
        _dir = transform.position.normalized * speed;        
        _rb.AddForce(transform.forward * speed);
        Destroy(gameObject, 3f);
    }
    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }   
}
