﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SMPlay2 : MonoBehaviour
{

    public enum GameState { IntroState, K1State, K2State, K3State, K4State, K5State, K6State, K7State };
    public GameState currentGameState;

    public GameObject Intro;
    public GameObject K1;
    public GameObject K2;
    public GameObject K3;
    public GameObject K4;
    public GameObject K5;
    public GameObject K6;
    public GameObject K7;

    public Text Checkcheck;
    public Text FinalScore;

    public AudioClip CorrectSound;
    private AudioSource audioSource;

    public List<CheckScore> checkScores;
    public int Score;

    public Text HiText;

    public CheckScore cs1;
    public CheckScore cs2;
    public CheckScore cs3;
    public CheckScore cs4;
    public CheckScore cs5;
    public CheckScore cs6;

    bool HasPlayed;

    // Use this for initialization
    
    void Start()
    {
        currentGameState = GameState.IntroState;
        ShowScreen(Intro);
        audioSource = GetComponent<AudioSource>();
        HasPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        HiText.text = "Match the dermatological conditions to their respective pictures. Each correct answer will add 25 points to your total score. If you fail to do so, 25 points will be deducted from your total score.  Good luck!";
        CSound();
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        Intro.SetActive(false);
        K1.SetActive(false);
        K2.SetActive(false);
        K3.SetActive(false);
        K4.SetActive(false);
        K5.SetActive(false);
        K6.SetActive(false);
        K7.SetActive(false);

        gameObjectToShow.SetActive(true);
    }
    public void CSound()
    {
        if (currentGameState == GameState.K1State && cs1.correct == true && HasPlayed == false)
        {
            audioSource.PlayOneShot(CorrectSound);
            HasPlayed = true;
        }
        if (currentGameState == GameState.K2State && cs2.correct == true && HasPlayed == false)
        {
            audioSource.PlayOneShot(CorrectSound);
            HasPlayed = true;
        }
        if (currentGameState == GameState.K3State && cs3.correct == true && HasPlayed == false)
        {
            audioSource.PlayOneShot(CorrectSound);
            HasPlayed = true;
        }
        if (currentGameState == GameState.K4State && cs4.correct == true && HasPlayed == false)
        {
            audioSource.PlayOneShot(CorrectSound);
            HasPlayed = true;
        }
        if (currentGameState == GameState.K5State && cs5.correct == true && HasPlayed == false)
        {
            audioSource.PlayOneShot(CorrectSound);
            HasPlayed = true;
        }
        if (currentGameState == GameState.K6State && cs6.correct == true && HasPlayed == false)
        {
            audioSource.PlayOneShot(CorrectSound);
            HasPlayed = true;
        }
    }
    public void Knowledge1()
    {
        currentGameState = GameState.K1State;
        ShowScreen(K1);
        HasPlayed = false;
    }
    public void Knowledge2()
    {
        currentGameState = GameState.K2State;
        ShowScreen(K2);
        HasPlayed = false;
    }
    public void Knowledge3()
    {
        currentGameState = GameState.K3State;
        ShowScreen(K3);
        HasPlayed = false;
    }
    public void Knowledge4()
    {
        currentGameState = GameState.K4State;
        ShowScreen(K4);
        HasPlayed = false;
    }
    public void Knowledge5()
    {
        currentGameState = GameState.K5State;
        ShowScreen(K5);
        HasPlayed = false;
    }
    public void Knowledge6()
    {
        currentGameState = GameState.K6State;
        ShowScreen(K6);
        HasPlayed = false;
    }
    public void Knowledge7()
    {
        currentGameState = GameState.K7State;
        ShowScreen(K7);
        GameOver();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Play()
    {
        SceneManager.LoadScene("Play1");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GameOver()
    {
        for (int i = 0; i < checkScores.Count; i++)
        {
            if(checkScores[i].correct == true)
            {
                Score += 25;
            }
        }
        FinalScore.text = "Score: " + Score;
        if (Score <= 0)
        {
            Checkcheck.text = "Seems like you had some trouble, might want to review your notes...";
        }
        else if (Score == 25)
        {
            Checkcheck.text = "Maybe you should try again...";
        }
        else if (Score == 50)
        {
            Checkcheck.text = "Halfway there...";
        }
        else if (Score == 75)
        {
            Checkcheck.text = "So close...";
        }
        else if (Score == 100)
        {
            Checkcheck.text = "Good job, you got all of them right...";
        }
    }

 
}