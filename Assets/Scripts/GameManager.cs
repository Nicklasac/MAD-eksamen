using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public Player player;
    public Text gameOverCountdown;
    public float countTimer = 5;
    public Text scoreText;
    public int score;
    public Text HStext;
    // Start is called before the first frame update
    void Start()
    {
       HStext.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");
        gameOverCountdown.gameObject.SetActive(false);
        
        Time.timeScale = 0;
         
    }

    // Update is called once per frame
    void Update()
    {
         if(player.isDead){
            RestartGame();
        }
       
    }

    public void StartGame(){
        startButton.gameObject.SetActive(false);
        Time.timeScale = 1;
        score = 0;
        scoreText.text = score.ToString();
    }

    public void GameOver(){
        
         if (score > PlayerPrefs.GetInt("highscore"))
        {
        PlayerPrefs.SetInt("highscore",score);
        }
        Time.timeScale = 0;
        
    }

    public void RestartGame(){
         
       
       SceneManager.LoadScene(0);
        
    }
    

    public void IncreaseScore(){
        score++;
        scoreText.text = score.ToString();
    }
}
