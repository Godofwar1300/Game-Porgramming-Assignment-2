/*
*(Christopher Green)
*(Game Controller.cs)
* (Assignment 2)
* (This scripts handles the timers and tutorial text as well as the game over condition)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    private float timer;
    private float duration;
    public Text timerText;

    public GameObject tutorialText;
    public Text messageTimer;
    public GameObject messageTimerObject;

    void Start()
    {
        StartCoroutine(TutorialTimer());
    }

    void Update()
    {

    }

    IEnumerator Timer()
    {
        duration = 30;

        while (duration > 0)
        {
            duration -= Time.deltaTime;
            timerText.text = "Timer: " + duration.ToString("00");
            yield return null;
        }

        if (duration <= 0)
        {
            GameOver();
        }

    }

    IEnumerator TutorialTimer()
    {
        duration = 15;

        while (duration > 0)
        {
            duration -= Time.deltaTime;
            messageTimer.text = "Tutorial Time Left: " + duration.ToString("00");
            yield return null;
        }

        if (duration <= 0)
        {
            tutorialText.SetActive(false);
            messageTimerObject.SetActive(false);
            StartCoroutine(Timer());
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
