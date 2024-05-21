/*
* Author: Mattias Tan
* Date: 19/5/2024
* Description: Purple key card to unlock the doors
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purple : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// The Door that this keycards unlock
    /// </summary>
    public DoorLeft linkedDoor1;


    private void Start()
    {
        // Check if there is a linkedDoor
        if (linkedDoor1 != null)
        {
            linkedDoor1.Setlock1(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Tell the door to unlock itself.
            linkedDoor1.Setlock1(false);
            Destroy(gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
