using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    public float jumpForce;    
    public GameObject bullet;
    public Transform firePoint;    
    public float x, y;
    float _jumpRate;
    float _nextJump;
    float _tpRate;
    float _fireRate;
    float _nextTp;
    float _rotationSpeed = 250f;
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
        _fireRate = 1.5f;
        _nextFire = Time.time;
        _tpRate = 10f;
        _nextTp = Time.time;
        _jumpRate = 2f;
        _nextJump = Time.time;
    }
    private void Update()
    {
        Move();
    }
    public void Move()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * _rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * speed);

        _anim.SetFloat("VelX", x);
        _anim.SetFloat("VelY", y);
    }    
    public void Teleport()
    {
        if (Time.time > _nextTp)
        {
            transform.Translate(0, 0, y * Time.deltaTime * speed + 4);
            _nextTp = Time.time + _tpRate;
        }        
    }
    public void Jump()
    {
        if (Time.time > _nextJump)
        {
            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            _nextJump = Time.time + _jumpRate;
        }
    }
    public void Shoot()
    {
        if(Time.time > _nextFire)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            _nextFire = Time.time + _fireRate;
        }       
    }
   
}
