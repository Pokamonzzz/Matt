/*
* Author: Mattias Tan
* Date: 19/5/2024
* Description:Ending screen
*/
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public bool openScreen = false;
    public GameObject EndingScreen;

    /// <summary>
    /// Ending screen to congratulate player
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !openScreen)
        {
            openScreen = true;
        }

    }

    public void endMenu()
    {
        EndingScreen.SetActive(true);
    }
    
    void OnEnd()
    {
        EndGame();
    }
    void EndGame()
    {
        EndingScreen.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (openScreen == true)
        {
            endMenu();
        }
    }
}
