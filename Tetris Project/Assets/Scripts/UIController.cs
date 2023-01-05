using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoSingleton<UIController>
{
    public GameObject HUDPanel;
    public TextMeshProUGUI ScoreValue;
    public TextMeshProUGUI LinesCleared;
    public void UpdateScore(int ScoreCount)
    {
        ScoreValue.text = "SCORE: <br>" + ScoreCount;
    } 
    public void UpdateLines(int LineCount)
    {
        LinesCleared.text = "LINE: <br>" + LineCount;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
