/*
* Author: Mattias Tan
* Date: 19/5/2024
* Description: Collectible like my star, coins and balls.
*/
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public int coin = 1;
    public int ball = 2;
    public int star = 10;
    public int block = 57;
    public int currentScore = 0;

    // StarCount for collectible
    public int starNum = 0;

    /// <summary>
    /// The collection function
    /// </summary>
    public void Collected()
    {
        Debug.Log(gameObject.name + " got HIT");
        Destroy(gameObject);
    }

    /// <summary>
    /// Increase score is from player.cs cause i make it to public
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        // both are true then collision will happen
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Coin")
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(coin);
            Collected();
        }

        // both are true then collision will happen
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Ball")
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(ball);
            Collected();
        }

        // both are true then collision will happen
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Blocks")
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(block);
            Collected();
        }

        // both are true then collision will happen star count will increase by calling the function
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Star")
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(star);
            Collected();
            // Increase the star count by 1 like 1/3 or 2/3
            collision.gameObject.GetComponent <Player>().IncreaseStar(1);
        }
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
