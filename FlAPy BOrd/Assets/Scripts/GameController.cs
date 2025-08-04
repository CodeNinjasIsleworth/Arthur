using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour{
    [Header("Game Over UI Object for displaying Game Over Screen")]
    public GameObject gameOverCanvas;
    [Header("Spawner Object for spawning objects in game")]
    public GameObject spawner;
    [Header("Score UI Object for displaying Score")]
    public GameObject scoreCanvas;

    void Start() {
        scoreCanvas.SetActive(true);
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);
        spawner.SetActive(true);
        }
     
    public void GameOver() {
        gameOverCanvas.SetActive(true);
        spawner.SetActive(false);
        Time.timeScale = 0;
    }



        
}
