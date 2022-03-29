using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFloor : MonoBehaviour
{
    public AudioSource victorySfx;
    private float _timeToNextLevel = 1f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            victorySfx.Play();
            Invoke("NextLevel", _timeToNextLevel);
        }
    }
    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
