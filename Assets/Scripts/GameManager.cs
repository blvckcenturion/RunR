using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    public static GameManager inst;

    public Text scoreText;

    public void Increment() 
    {
        score++;
        scoreText.text = "Puntaje: " + score;
    }

    private void Awake ()
    {
        inst = this;
    }

}
