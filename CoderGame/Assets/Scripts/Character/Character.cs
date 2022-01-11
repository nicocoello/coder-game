using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    public float jumpForce;    
    public GameObject bullet;
    public Transform firePoint;
    public float fireRate;
    public float x, y;
    float _rotationSpeed = 50f;
    float _nextFire;
    Rigidbody _rb;
    Animator _anim;
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }
    private void Start()
    {
        fireRate = 1.5f;
        _nextFire = Time.time;
    }
    private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * _rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * speed);

        _anim.SetFloat("VelX", x);
        _anim.SetFloat("VelY", y);
    }

    public void Jump()
    {
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    public void Shoot()
    {
        if(Time.time > _nextFire)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            _nextFire = Time.time + fireRate;
        }       
    }
   
}
