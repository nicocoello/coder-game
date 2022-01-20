using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearBox : MonoBehaviour
{
    public float time;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke("Destroy", time);            
        }
    }    
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
