using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private AudioSource _button;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Text CoinText;
    public Image CoinImg;   
    public int coins = 0;
    private void Update()
    {
        //Pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
               Resume();
            }
            else
            {
               Pause();
            }
        }
        //Coins
        CoinText.text = "Coins : " + coins;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        CoinText.enabled = true;
        CoinImg.enabled = true;      

    }   
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0f;
        GameIsPaused = true;
        CoinText.enabled = false;
        CoinImg.enabled = false;
    }
    public void OnClick()
    {
        _button.Play();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Debug.Log("Quit");
        //Esto hay que comentarlo antes de hacer la build porque si no se va a romper
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
