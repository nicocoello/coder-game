using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    PauseMenu canvas;
    [SerializeField] private GameObject _coin;
    [SerializeField] private AudioSource _coinSfx;
    private void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<PauseMenu>();
    }

    void Update()
    {
        transform.RotateAround(_coin.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            _coinSfx.Play();
            canvas.coins++;
            Destroy(gameObject);
        }
    }
}
