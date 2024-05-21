/*
 * Author: Mattias Tan
 * Date: 26 April 2024
 * Description: CA1 Unity Input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CA1 : MonoBehaviour
{

    //Task 1
    int bigNum = 30;
    int smallNum = 8;

    /// <summary>
    /// A Function to check if numbers are equal if not print the larger one
    /// </summary>
    void NumDiff()
    {
        if (bigNum == smallNum)
        {
            Debug.Log("The numbers are equal");
        }
        else
        {
            if (bigNum > smallNum)
            {
                Debug.Log(bigNum);
            }
            else
            {
                Debug.Log(smallNum);
            }
        }
    }

    //Task 2 using a for loop
    string single = "";

    /// <summary>
    /// print numbers from 1 to 10 using for loop
    /// </summary>
    void ForPrint()
    {
        for(int i = 1; i <= 10; i++)
        {
            single = single + "" + i;
        }
        Debug.Log(single);
    }

    //Task 3 Using while Loop

    /// <summary>
    /// Print hello world 10 times using while loop
    /// </summary>
    void WhileLoop()
    {
        // Give an integer
        int i = 0;
        while (i < 10)
        {
            Debug.Log("Hello World");
            // Make it increase in increments of 1
            ++i;
        }
    }

    /// <summary>
    /// Call the function with inputs
    /// </summary>
    
    void OnNum()
    {
        NumDiff();
    }

    void OnFor()
    {
        ForPrint();
    }    

    void OnWhile()
    {
        WhileLoop();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Call the Function
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
