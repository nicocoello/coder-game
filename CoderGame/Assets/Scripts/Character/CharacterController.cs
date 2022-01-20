using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{    
    Character _character;
    
    void Awake()
    {
        _character = GetComponent<Character>();
        
    }
    void Update()
    {
      
        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {            
            _character.Jump();            
        }  
        //Shoot
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            _character.Shoot();
        }    
        //Tp
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _character.Teleport();            
        }
        //Run
        if (Input.GetKeyDown(KeyCode.LeftShift))
            _character.Run();
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            _character.speed = 5f;   
        //Crouch
        if (Input.GetKeyDown(KeyCode.LeftControl))        
            _character.Crouch();
            else if (Input.GetKeyUp(KeyCode.LeftControl))
            _character.GoUp();
    }
}