using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public static GameController instance;            //A reference to our game control script so we can access it statically.
    public Text scoreText;                        //A reference to the UI text component that displays the player's score.
    public GameObject gameover;                //A reference to the object that displays the text which appears when the player dies.
    public GameObject restart;
    private int score = 0;                        //The player's score.
    public bool gameOver = false;                //Is the game over?
    public float scrollSpeed = -1.5f;
    
    void Awake()
    {
        //If we don't currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if (instance != this)
            //...destroy this one because it is a duplicate.
            Destroy(gameObject);
    }
    public void Update()
    {
        if(gameOver==true && Input.GetKeyDown("c"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        
    }

    public void BirdScored()
    {
        //The bird can't score if the game is over.
        if (gameOver)
            return;
        //If the game is not over, increase the score...
        score++;
        //...and adjust the score text.
        scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        //Activate the game over text.
        gameover.SetActive(true);
        restart.SetActive(true);

        //Set the game to be over.
        gameOver = true;
    }
}
