using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    //The different game states
    private GameObject startGame;

    private GameObject movingStart;

    private GameObject GameOver;

    //If the game starts...
    public void StartGame()
    {
        //Finds the menu screen
        startGame = GameObject.Find("Menu");
        //Finds the player
        movingStart = GameObject.Find("Player");
        //Allows the player to move when the game "starts"
        movingStart.GetComponent<Controller>().moveCheck = 1;
        GameObject.Find("MovingPlatform").GetComponent<BoxMoving>().moveCheck = 1;
        GameObject.Find("LevelMusic").GetComponent<AudioSource>().Play();

        //Rinky dink way of moving the "Game Over" screen, but it's the only way I've found that works
        startGame.GetComponent<CanvasScaler>().scaleFactor = 0;
        startGame.GetComponent<Image>().color = new Color(255, 255, 255, 0);
        startGame.GetComponent<Button>().GetComponent<Image>().color = new Color(0, 255, 0, 0);
    }

    //Loads the next level, but the button does not work
    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
        Debug.Log("Click!");
    }

    public void ExitGame()
    {
        //Closes the game
        Application.Quit();
    }

}
