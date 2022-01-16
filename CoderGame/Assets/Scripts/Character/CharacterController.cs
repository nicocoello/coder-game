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
        //Solo para el desafio entregable, despues voy a dejar solo con el click del mouse
        if(Input.GetKeyDown(KeyCode.Mouse0) ||Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L)) 
        {
            _character.Shoot();
        }        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _character.Teleport();            
        }
    }
}
