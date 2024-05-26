using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Class_Collectible : Interactable
{
    //bool isCollected = false;
    //float expirationTime = 5.5f;
    //string myName = "Just a Coin";

    //bool isDropped = false;
    //int itemDropped = 1;
    //float itemDisappear = 3.5f;
    //string itemName = "Ball";
    //int itemIndex = 0;

    //void DropItem()
    //{

    //}
    //void UseItem() 
    //{

    //}
    //void RecycleItem()
    //{

    //}
    //void GetCollected()
    //{
    //    Debug.Log("I got collected");
    //}

    //int demoInt = 3;
    //int secondInt = 5;
    //bool demobool = false;


    //Lesson 2 Exercise 2
    //int a = 1;
    //int x = 5;
    //int y = 9;

  //void QuickMath()
  //{
  //    // Check if a is smaller than x
  //    if (a < x)
  //    {
  //        a += y; 
  //        // Check if a and y is smaller than x
  //        if (a < x)
  //        {
  //            Debug.Log("x is the biggest number");
  //        }
  //        else
  //        {
  //            Debug.Log("x is not the biggest number");
  //        }
  //    }
  //    else
  //    {
  //        Debug.Log("NO");
  //    }
  //}


    /// <summary>
    /// Increase score is from player.cs cause i make it to public
    /// </summary>
    /// <param name="collision"></param>

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("the Collision stopped");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("stop");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("something entered me");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("something left me");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("something is inside me");
    }



    // Start is called before the first frame update
    void Start()
    {
        // Calling the GetCollected() function
        //GetCollected();

        //QuickMath();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
