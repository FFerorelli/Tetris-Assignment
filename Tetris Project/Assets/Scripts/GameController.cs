using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoSingleton<GameController>
{
    public int score = 0;
    public int lines = 0;
    public int lineCombo = 0;
    public bool isPaused = false;
    public void AddScore()
    {
        int points = 0;
        switch (lineCombo)
        {
            case 1: 
                points = 40;
                break;
            case 2: 
                points = 100;
                break;
            case 3: 
                points = 300;
                break;
            case 4: 
                points = 1200;
                break;
            case > 4:
                points = 2000;
                break;

        }
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
