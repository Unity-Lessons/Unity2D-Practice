using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour {

    int avg, min, max;

    public Text myText, numberText, winText;

	// Use this for initialization
	void Start () {
        Reset();
	}

    void Reset()
    {
        myText.text = "Is your number:";
        numberText.text = "500";
        max = 1000;
        min = 1;
    }

    void NextGuess()
    {
        avg = Avg(min, max);
    }

    // Update is called once per frame
    void Update ()
    {
        NextGuess();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = avg;
            NextGuess();

            if (avg == min)
            {
                myText.text = "Is your number:";
                numberText.text = avg + "~~";
            }
            else if (avg < 999)
            {
                myText.text = "Is the number higher or lower than:";
                numberText.text = avg + "?";
            }
            else if (avg == 999)
            {
                avg += 1;
                Won();
            }

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = avg;
            NextGuess();

            if (avg == max)
            {
                myText.text = "Is your number:";
                numberText.text = avg + "~~";
            }
            else if (avg > 1)
            {
                myText.text = "Is the number higher or lower than:";
                numberText.text = avg + "?";
            }
            else if (avg == 1)
                Won();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Won();
        }
    }

    int Avg(int minNum, int maxNum)
    {
        return (minNum + maxNum) / 2;
    }

    void Won()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
