using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max, min, avg;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Reset();
        print("========================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");

        print("Pick a number between " + min + " and " + max + ".");

        print("Is the number higher or lower than " + max / 2 + "?");
        print("Up = Higher, Down = Lower, Return = Equal");
    }

    void Reset()
    {
        max = 1000;
        min = 1;
    }

    void NextGuess()
    {
        avg = Avg(min, max);
    }

    // Update is called once per frame
    void Update()
    {
        NextGuess();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = avg;
            NextGuess();

            if (avg == min)
            {
                print("Is your number " + avg + "?");
            }
            else if (avg < 999)
            {
                print("Your number is greater than " + min);
                print("Is the number higher or lower than " + avg + "?");
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
                print("Is your number " + avg + "?");
            }
            else if (avg > 1)
            {
                print("Your number is less than " + max);
                print("Is the number higher or lower than " + avg + "?");
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
        print("I got it! Your number is " + avg + "!");
        StartGame();
    }
}
