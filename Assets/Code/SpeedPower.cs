using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using StarterAssets;

public class SpeedPower : Collectible
{
    /// <summary>
    /// Was testing it out
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Collected();
        }
    }

    float move = 20f;

    public override void Collected()
    {
        base.Collected();
        GetComponent<StarterAssets.FirstPersonController>().MoveSpeed = move;
    }

    /// <summary>
    /// finally got it
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AddSpeed(other);
            Destroy(gameObject);
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
