using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameUIManager : MonoBehaviour
{
    public GameObject losePanel, winPanel, gameOverPanel;
    public TextMeshProUGUI lifes;
    
    void OnEnable () {
        GameManager.lose += OnLose;
        GameManager.win += OnWin;
        GameManager.gameOver += OnGameOver;
    }

    void OnDisable () {
        GameManager.lose -= OnLose;
        GameManager.win -= OnWin;
        GameManager.gameOver -= OnGameOver;
    }

    void OnLose () {
        losePanel.SetActive(true);
    }

    void OnGameOver () {
        gameOverPanel.SetActive(true);
    }

    void OnWin () {
        winPanel.SetActive(true);
    }

    public void PlayAgain () {
        SceneManager.LoadScene(1);
    }

    public void GoToMainMenu () {
        GameManager.ResetLifes();
        SceneManager.LoadScene(0);
    }
    
    void Start () {
        lifes.text = GameManager.life.ToString();
    }
}
