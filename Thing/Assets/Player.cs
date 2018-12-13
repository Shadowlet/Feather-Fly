using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private int number = 5;
    private int numberTwo = 10;

    private bool isOnGround = false;

    private string name = " Something";
    private string lastName = "Thing";

	// Use this for initialization
	void Start () {


        /*if (isOnGround)
        {
            Debug.Log("True");
        }
        else if (isOnGround)
        {
            Debug.Log("Else if");
        }
        else
        {
            Debug.Log("False");
        }*/

        //number = number % number;
        //number = number + numberTwo;
        //number = number + number;
        //Debug.Log(number);
        AddNumbers(16, 26);
	}
    
    public void AddNumbers(int numOne, int numTwo)
    {
        if (number > 10 || numberTwo == 10 && number == 5)
        {
            Debug.Log("True");
        }
        else if (number < 10)
        {
            Debug.Log("Else if");
        }
        else
        {
            Debug.Log("False");
        }
        //number = numOne + numTwo;
        //Debug.Log(number);
    }

	// Update is called once per frame
	void Update () {

	}
}
