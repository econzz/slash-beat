using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public Text comboText;

    private int currentScore;
    private int currentCombo;

    public SaberScript leftBlueSaber;
    public SaberScript rightRedSaber;

    private bool onCombo;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        currentCombo = 0;
        scoreText.text = ""+currentScore;
        comboText.text = "" + currentCombo;

        onCombo = false;
    }

    void addCombo(int value)
    {
        currentCombo = value;
        comboText.text = "" + currentCombo;
    }

    void addScore(int value)
    {
        currentScore += value;
        scoreText.text = "" + currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftBlueSaber.checkCollision()){
            onCombo = true;
            addCombo(1);

            addScore(100);
        }
        else
        {
            currentCombo = 0;
            comboText.text = "" + currentCombo;
        }

        if (rightRedSaber.checkCollision()) {
            onCombo = true;
            addCombo(1);
            addScore(100);
        }
        else
        {
            currentCombo = 0;
            comboText.text = "" + currentCombo;
        }


    }
}
