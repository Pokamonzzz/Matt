/*
* Author: Mattias Tan
* Date: 19/5/2024
* Description: Collectible like my star, coins and balls.
*/
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using StarterAssets;

public class Collectible : MonoBehaviour
{

    [SerializeField]
    private AudioClip collectAudio;

    public static int coin = 1;
    public int ball = 2;
    public int star = 10;
    public int block = 57;
    public int currentScore = 0;

    // StarCount for collectible
    public int starNum = 0;

    /// <summary>
    /// The collection function
    /// </summary>
    public virtual void Collected()
    {
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);
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
      //if (collision.gameObject.tag == "Player" && gameObject.tag == "Coin")
      //{
      //    GameManager.Instance.IncreaseScore(coin);
      //    //collision.gameObject.GetComponent<Player>().IncreaseScore(coin);
      //    Collected();
      //}

        // both are true then collision will happen
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Ball")
        {
            //collision.gameObject.GetComponent<Player>().IncreaseScore(ball);
            Collected();
        }

        // both are true then collision will happen
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Blocks")
        {
            //collision.gameObject.GetComponent<Player>().IncreaseScore(block);
            Collected();
        }

        // both are true then collision will happen star count will increase by calling the function
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Star")
        {
            //collision.gameObject.GetComponent<Player>().IncreaseScore(star);
            Collected();
            // Increase the star count by 1 like 1/3 or 2/3
            collision.gameObject.GetComponent <Player>().IncreaseStar(1);
        }
    }



    // CA2
    public void AddSpeed(Collider other)
    {
        other.gameObject.GetComponent<FirstPersonController>().MoveSpeed = 20f;
    }

    public void AddJump(Collider other)
    {
        other.gameObject.GetComponent<FirstPersonController>().JumpHeight = 5f;
    }
}
