﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    public int score;
    public Text scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore() {

        score++;
        scoreTxt.text = score.ToString();

    }

    public void subScore()
    {

        score--;
        scoreTxt.text = score.ToString();

    }
}
