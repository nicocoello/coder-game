using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    Character _player;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);            
        }
        else
        {
            Debug.Log("Se destruye el objeto duplicado");
            Destroy(gameObject);
        }
    }    
    public void Victory()
    {
        SceneManager.LoadScene("VictoryScene");
    }
    
    
}

