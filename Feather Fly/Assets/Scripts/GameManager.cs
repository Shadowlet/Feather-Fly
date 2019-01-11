using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {
    public GameObject startMenu;
    public GameObject pauseMenu;
    public GameObject game;
    public GameObject deathScreen;
   

    public bool playerDead = false;

    //public bool gameRun = true;
    


	// Initialize S
	void Start() {
        startMenu.SetActive(true);

        pauseMenu.SetActive(false);
        game.SetActive(false);
        deathScreen.SetActive(false);

	}
	
	// Update is called once per frame
	
    public void StartGame()
    {
       
        startMenu.SetActive(false);
        game.SetActive(true);
    }

    public void PauseMenu()
    {
        // "Pause" the game.
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        // "Resume" the game.
        Time.timeScale = 1;
    }

    public void DeathScreen()
    {
        Debug.Log("Death is here");
        game.SetActive(false);
        deathScreen.SetActive(true);

    }

    // Load same scene
    public void StartAgain()
    {
        Debug.Log("fcgh");
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        // Pause the game
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
                Debug.Log("paused?");
                PauseMenu();
        }
        // Resume the game
        if (Input.GetKeyDown(KeyCode.Return))
        {
                Debug.Log("resumed");
                ResumeGame();
        }
    }

}
