using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using abx;
using System;
using TMPro;

public class Score : MonoBehaviour
{
    public PlayerBall x;
    public TextMeshProUGUI scoretext;
    public int score;
    //public float i;
    
    // Start is called before the first frame update
    void Start()
    {
       
       //score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Math.Round(x.scoreball));
        //i = x.scoreball;
        scoretext.text = Math.Round(x.scoreball).ToString();

    }
}
 