using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text ScoreText;
    int Score = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
       ScoreText.text = Score.ToString() + "  POINTS";
    }

    public void AddScore()
    {

        Score+= 1000;
        ScoreText.text = Score.ToString() + "  POINTS";
    }

    public void AddScore2()
    {

        Score += 2000;
        ScoreText.text = Score.ToString() + "  POINTS";
    }

    public void AddScore3()
    {

        Score += 3000;
        ScoreText.text = Score.ToString() + "  POINTS";
    }

    public void AddScore4()
    {

        Score += 4000;
        ScoreText.text = Score.ToString() + "  POINTS";
    }
}
