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
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        if (h != 0 || v != 0)
            _character.Move(dir);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _character.Jump();
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            _character.Shoot();
        }
    }
}
