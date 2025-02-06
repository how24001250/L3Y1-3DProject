using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameplayMenu;

    public bool isPaused;

    private void Start() {
        pauseMenu.SetActive(false);
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(!isPaused) {
                PauseGame();
            }
            else if (isPaused) {
                ResumeGame();
            }
        }
    }

    public void ResumeGame() {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        gameplayMenu.SetActive(true);
    }

    public void PauseGame() {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        gameplayMenu.SetActive(false);
    }
}
