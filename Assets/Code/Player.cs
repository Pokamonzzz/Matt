/*
* Author: Mattias Tan
* Date: 19/5/2024
* Description: Player Script
*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// The current score
    /// </summary>
    //public int currentScore = 0;
    public int starNum = 0;
    // Make Public so other c# can use

    /// <summary>
    /// Store the current door in front of the player
    /// </summary>
    Door currentDoor;

    DoorLeft currentDoor1;

    /// <summary>
    /// Store the current collectible
    /// </summary>
    Collectible currentCollectible;

    Interactable currentInteractable;

    GiftBox currentGift;

    /// <summary>
    /// This willl store the text object in the scene
    /// </summary>
    // moved to Game manager 
    //public TextMeshProUGUI scoreText;

    public GameObject textBox;

    public TextMeshProUGUI starText;

    /// <summary>
    /// Increase the score of the player by however much i chose. 
    /// </summary>
    /// <param name="scoreToAdd"></param>
  //public void IncreaseScore(int scoreToAdd)
  //{
  //    currentScore += scoreToAdd;
  //    Debug.Log(currentScore);
  //
  //    // scoreText is the variable the .text is the ui text. to string is to make an integer to a string.
  //
  //    scoreText.text = currentScore.ToString();
  //}
    /// <summary>
    /// Increase th number of stars needed to be collected or how many are left
    /// </summary>
    /// <param name="starAmt"></param>
    /// 

    public GameObject starCollect;
    public void IncreaseStar(int starAmt)
    {
        starNum += starAmt;
        Debug.Log(starAmt);

        starText.text = starNum.ToString() + "/3";
        if (starNum == 3)
        {
            Debug.Log("NOOOO");
            starCollect.SetActive(true);
        }
    }

    /// <summary>
    /// Remove the instructions
    /// </summary>
    void GameStart()
    {
        // Textbox of game instructions dissapears
        textBox.SetActive(false);
    }
    
    void OnBegin()
    {
        // Calling the functions
        GameStart();
    }
    /// <summary>
    /// The Ending screen after opening the final door
    /// </summary>
    public bool openScreen = false;
    public GameObject EndingScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !openScreen)
        {
            openScreen = true;
            endMenu();
        }

    }

    public void endMenu()
    {
        EndingScreen.SetActive(true);
        openScreen = false;
    }

    void OnEnd()
    {
        // Calling the function
        EndGame();
        openScreen = false;
        Debug.Log("hello");
    }
    void EndGame()
    {
        EndingScreen.SetActive(false);
    }

  //public void UpdateInteractable(Interactable newInteractable)
  //{
  //    currentInteractable = newInteractable;
  //}

    public void UpdateDoor(Door newDoor)
    {
        // store the door
        currentDoor = newDoor;
    }

    public void UpdateDoorLeft(DoorLeft newDoor1)
    {
        currentDoor1 = newDoor1;
    }

    public void UpdateCollectible(Collectible newCollectible)
    {
        currentCollectible = newCollectible;
    }
    /// <summary>
    /// Interact function to open doors
    /// </summary>
    void OnInteract()
    {
        if(currentInteractable != null)
        {
            currentInteractable.Interact(this);
        }
        // Check if its null
        if (currentDoor != null)
        {
            currentDoor.OpenDoor();
            currentDoor = null;
        }
        if (currentDoor1 != null)
        {
            currentDoor1.OpenDoor1();
            currentDoor1 = null;
        }
     
        // collect the coin on click with the interact key
        if (currentCollectible != null)
        {
            //IncreaseScore(currentCollectible.currentScore);
            currentCollectible.Collected();
        }
        if (currentGift != null)
        {
            currentGift.collectGift();
        }

    }

    // CA3
    [SerializeField]
    Transform playerCamera;

    [SerializeField]
    float interactionDistance;

    [SerializeField]
    TextMeshProUGUI interactionText;

    private void Update()
    {
        Debug.DrawLine(playerCamera.position, playerCamera.position + (playerCamera.forward * interactionDistance), Color.red);
        RaycastHit hitInfo;
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out hitInfo, interactionDistance))
        {
            // print out the name of whatever my ray hit
            Debug.Log(hitInfo.transform.name);
            // shd be <interactable> out currentInteractable but i dont have anything set to the interactable.
            // for door to turn need change it to <Door>(out currentDoor)
            // why is the UI not showing up???
            if (hitInfo.transform.TryGetComponent<GiftBox>(out currentGift))
            {
                //Display some interation text
                interactionText.gameObject.SetActive(true);
            }
            else
            {
                currentInteractable = null;
                interactionText.gameObject.SetActive(false);
            }
            if (hitInfo.transform.TryGetComponent<Collectible>(out currentCollectible))
            {
                //Display some interation text
                interactionText.gameObject.SetActive(true);
            }
            else
            {
                currentInteractable = null;
                interactionText.gameObject.SetActive(false);
            }
        }
        else
        {
            currentInteractable = null;
            interactionText.gameObject.SetActive(false);
        }
    }
}
