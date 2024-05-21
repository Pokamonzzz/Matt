/*
* Author: Mattias Tan
* Date: 19/5/2024
* Description: red card to unlock other doors as well
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard : MonoBehaviour
{
    /// <summary>
    /// The Door that this keycards unlock
    /// </summary>
    public Door linkedDoor;


    private void Start()
    {
        // Check if there is a linkedDoor
        if(linkedDoor != null)
        {
            linkedDoor.Setlock(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            // Tell the door to unlock itself.
            linkedDoor.Setlock(false);
            Destroy(gameObject);

        }
    }



    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        
    }
}
