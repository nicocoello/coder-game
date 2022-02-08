using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearBox : MonoBehaviour
{
    
    [SerializeField] private GameObject _box;    
    public float timeToDestroy;
    private float _timeToRespawn = 10f;    
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke("Destroy", timeToDestroy);
            Invoke("BoxRespawn", _timeToRespawn);
        }
    }
    public void Destroy()
    {
        _box.SetActive(false);     
    }
    public void BoxRespawn()
    {
        _box.SetActive(true);        
    }
}
