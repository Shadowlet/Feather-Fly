using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject menu;
    public GameObject game;
    public GameObject gameOver;
    private int[] testing;
    //private List<GameObject> name;

	// Use this for initialization
	void Start () {
        game.SetActive(false);
        gameOver.SetActive(false);
        testing = new int[10];
        //name.Add("?");

        testing[0] = 10;
        testing[1] = 300;

        for(int i = 0; i < testing.Length; i++)
        {
            Debug.Log(i);
        }
	}

    public void GameOver()
    {
        game.SetActive(false);
        gameOver.SetActive(true);

    }
	
    public void StartGame()
    {
        menu.SetActive(false);
        game.SetActive(true);
    }

    
	private void Update()
    {

    }
	
}
