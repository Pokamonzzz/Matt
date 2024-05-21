/*
* Author: Mattias Tan
* Date: 19/5/2024
* Description: One side of the Door to open on interact
*/
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool opened = false;

    bool locked = false;

    private void OnTriggerEnter(Collider other)
    {
        //Check if the GameObject that enterted
        //the Trigger has the "Player" tag
        if (other.gameObject.tag == "Player" && !opened)
        {
            // Open the door
            //OpenDoor();


            // Update the player which the door its in front of
            other.gameObject.GetComponent<Player>().UpdateDoor(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            // If player not in front of the door the door will not open
            // Change to null to say the door is not there
            other.gameObject.GetComponent<Player>().UpdateDoor(null);
        }
    }

    /// <summary>
    /// Opening the door function
    /// </summary>
    public void OpenDoor()
    {
        // locked so that doors that does not need key cards can still open
        if (!locked)
        {
            // Handle the logic of opening the dorr

            Vector3 newRotation = transform.eulerAngles;
            newRotation.y += 90f;
            transform.eulerAngles = newRotation;


            // opened = true makes the door not turn anymore
            opened = true;
        }

    }


    // if got time to do closing of door
    void CloseDoor()
    {
        //Close Door
        Vector3 newRotation = transform.eulerAngles;
        newRotation.y -= 90f;
        transform.eulerAngles = newRotation;


        // opened = true makes the door not turn anymore
        opened = false;

    }
    public void Setlock(bool lockedStatus)
    {
        locked = lockedStatus;

    }


    // Simple way of locking/unlocking Door
  //public void LockDoor()
  //{
  //    locked = true;
  //}
  //
  //public void UnlockDOor()
  //{
  //    locked = false;
  //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
