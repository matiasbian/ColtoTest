using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameUIManager : MonoBehaviour
{
    public GameObject losePanel, winPanel, gameOverPanel;
    
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
        SceneManager.LoadScene(0);
    }
}
