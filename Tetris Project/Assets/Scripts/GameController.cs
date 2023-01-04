using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoSingleton<GameController>
{
    public int score = 0;
    public int lines = 0;
    public bool isPaused = false;
    public void AddScore(int points)
    {
        score += points;
        UIController.Instance.UpdateScore(score);
    } 
    public void AddLine(int addedLine)
    {
        lines += addedLine;
        UIController.Instance.UpdateLines(lines);
    }
    public void ResetGame()
    {
        score = 0;
        lines = 0;
        UIController.Instance.UpdateScore(score);
        UIController.Instance.UpdateLines(lines);
        AudioController.Instance.StopThemeMusic();
        AudioController.Instance.PlayThemeMusic();

    }

    // Start is called before the first frame update
    void Start()
    {
        UIController.Instance.UpdateScore(score);
        UIController.Instance.UpdateLines(lines);
        AudioController.Instance.PlayThemeMusic();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
