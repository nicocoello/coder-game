using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public AudioSource jumpAudio; 
    public float speed;
    float jumpForce = 5f;      
    float _runRate;
    float _nextRun;
    float _jumpRate;
    float _nextJump;   
    float _originalHeight; 
    float reducedHeight;
    CapsuleCollider _col;
    Rigidbody _rb;
    GameManager _gm;
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();        
        _col = GetComponent<CapsuleCollider>();
    }
    private void Start()
    {       
        _jumpRate = 1f;
        _nextJump = Time.time;
        _runRate = 5f;
        _nextRun = Time.time;
        _originalHeight = _col.height;        
    }
    private void Update()
    {
        Move();
    }    
    public void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");        
        transform.Translate(x*Time.deltaTime*speed, 0, z * Time.deltaTime * speed); 
    }        
    public void Jump()
    {
        if (Time.time > _nextJump)
        {
            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);            
            jumpAudio.Play();            
            _nextJump = Time.time + _jumpRate;            
        }
    }  
    public void Run()
    {
        if (Time.time > _nextRun)
        {
            speed = 10f;
            _nextRun = Time.time + _runRate;
        }        
    }
    public void Crouch()
    {
        _col.height = reducedHeight;        
    }
    public void GoUp()
    {
        _col.height = _originalHeight;
    }
}
