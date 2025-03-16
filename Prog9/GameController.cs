using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public static int score = 0;
    public Text display;
    public GameObject button;
    public int maxScore = 4;

     void Start()
    {
        if(SceneManager.GetActiveScene().name == "Level 2")
        {
            score = 0;
            maxScore = 6;
            display.text = "Score:" + score;
        }
        if (instance == null)
            instance = this;
        button.SetActive(false);
    }
    public void updateScore()

    {
        score++;
        display.text = "Score: " + score;
    }
     void Update()
    {
     if(score==maxScore)
        {
            Debug.Log("You Won !!");
            display.text = "You Won !!";
            button.SetActive(true);

        }
    }
    public void nextLevel()
    {
        SceneManager.LoadScene("Level 2");
    }
}