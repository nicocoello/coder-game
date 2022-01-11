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
      

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _character.Jump();            
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            _character.Shoot();
        }        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _character.Teleport();            
        }
    }
}
