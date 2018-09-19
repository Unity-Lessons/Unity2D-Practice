using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

    int textNumber;
    public Text myOne, myTwo, myThree, myFour, myFive, mySix, mySeven, myEight, myNine, myZero;

	// Use this for initialization
	void Start () {
		
	}

    void successfulEntry()
    {
        textNumber = Random.Range(0, 9);
    }
	
	// Update is called once per frame
	void Update () {
        if(textNumber == 0)
        {
            myZero.text = "0";
        }
        if (textNumber == 1)
        {
            myZero.text = "1";
        }
        if (textNumber == 2)
        {
            myZero.text = "2";
        }
        if (textNumber == 3)
        {
            myZero.text = "3";
        }
        if (textNumber == 4)
        {
            myZero.text = "4";
        }
        if (textNumber == 5)
        {
            myZero.text = "5";
        }
        if (textNumber == 6)
        {
            myZero.text = "6";
        }
        if (textNumber == 7)
        {
            myZero.text = "7";
        }
        if (textNumber == 8)
        {
            myZero.text = "8";
        }
        if (textNumber == 9)
        {
            myZero.text = "9";
        }

    }
}
