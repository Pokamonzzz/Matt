/*
* Author: Mattias Tan
* Date: 19/5/2024
* Description: One side of the Door to open on interact
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLeft : MonoBehaviour
{

    bool opened = false;

    bool locked1 = false;
    

    private void OnTriggerEnter(Collider other)
    {
        //Check if the GameObject that enterted
        //the Trigger has the "Player" tag
        if (other.gameObject.tag == "Player" && !opened)
        {
            // Open the door
            //OpenDoor();

            // Update the player which the door its in front of

            // I Dont know how to fix this issue :)

            other.gameObject.GetComponent<Player>().UpdateDoorLeft(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // If player not in front of the door the door will not open
            // Change to null to say the door is not there
            other.gameObject.GetComponent<Player>().UpdateDoorLeft(null);
        }
    }
    /// <summary>
    /// Opening the door function
    /// </summary>
    public void OpenDoor1()
    {
        // locked so that doors that does not need key cards can still open
        if (!locked1)
        {
            // Handle the logic of opening the dorr
            Vector3 newRotation = transform.eulerAngles;
            newRotation.y -= 90f;
            transform.eulerAngles = newRotation;
            // opened = true makes the door not turn anymore
            opened = true;
        }
    }

    public void Setlock1(bool lockedStatus)
    {
        locked1 = lockedStatus;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
