using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI mainText;
    public int pillarNum;

    public static GameManager Karen;

    private void Start()
    {
        Karen = this;
        mainText.text = "Knock off all the pillars to win!";
    }

    private void Update()
    {
        scoreText.text = "Pillars Left: " + pillarNum;
        if(Time.timeSinceLevelLoad > 10f)
        {
            mainText.enabled = false;
        }
        if(pillarNum <= 0)
        {
            mainText.enabled = true;
            mainText.text = "Wow! Incredible! yOu ArE a TrUe GaMeR!";
        }
    }
}
