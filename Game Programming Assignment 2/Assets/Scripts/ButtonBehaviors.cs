using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviors : MonoBehaviour
{
    bool canPause;
    bool isInMainMenu;

    GameObject pauseMenu;
    GameObject mainMenu;

    private void Awake()
    {
        mainMenu = GameObject.Find("Canvas").transform.GetChild(0).gameObject;
        pauseMenu = GameObject.Find("Canvas").transform.GetChild(1).gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        isInMainMenu = true;
    }

    // Update is called once per frame
    void Update()
    { 
        if (isInMainMenu)
        {
            mainMenu.SetActive(true);
            canPause = false;
        }
        else
        {
            isInMainMenu = false;
        }

        if (SceneManager.GetActiveScene().name == "Game Menu")
        {
            canPause = true;
            mainMenu.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape) && canPause)
            {
                PauseGame();
            }

            Debug.Log("canPause is " + canPause);
        }
        else
        {
            canPause = false;

            Debug.Log("canPause is " + canPause);
        }
    }

    /// <Functionality of the main menu buttons>
    /// Main Menu Button Functions
    /// <Functionality of the main menu buttons>

    // When pressed, this button starts the game.
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // When pressed, this button quits the game and/or shuts down the application.
    public void ExitGame()
    {
        Application.Quit();
    }

    /// <Functionality of the pause menu buttons>
    /// Pause Menu Button Functions
    /// <Functionality of the pause menu buttons>

    // Takes care of pausing the game when the escape button is pressed.
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    // Resumes the game.
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
