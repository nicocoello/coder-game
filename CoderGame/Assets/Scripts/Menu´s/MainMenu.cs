using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 
    [SerializeField] AudioSource buttonAudio;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        //Esto hay que comentarlo antes de hacer la build porque si no se va a romper
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void OnClick()
    {
        buttonAudio.Play();
    }    
}
