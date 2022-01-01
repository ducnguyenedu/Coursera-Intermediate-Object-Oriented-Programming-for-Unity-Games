﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The game over message
/// </summary>
public class GameOverMessage : MonoBehaviour
{
    [SerializeField]
    Text messageText;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // pause the game when added to the scene
        Time.timeScale = 0;
    }

    /// <summary>
    /// Sets score
    /// </summary>
    /// <param name="score">score</param>
    public void SetScore(int score)
    {
        messageText.text = "Game Over!\n\nYour score: " +
            score.ToString();
    }

    /// <summary>
    /// Moves to main menu when quit button clicked
    /// </summary>
    public void HandleQuitButtonClicked()
    {
        // unpause game, destroy menu, and go to main menu
        AudioManager.Play(AudioClipName.MenuButtonClick);
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.Main);
    }
}
