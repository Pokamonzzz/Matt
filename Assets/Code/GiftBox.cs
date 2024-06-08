using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftBox : MonoBehaviour
{
    [SerializeField]
    private GameObject collectibleToSpawn;
    [SerializeField]
    private AudioClip giftCollect;


  //private void OnCollisionEnter(Collision collision)
  //{
  //    if(collision.gameObject.tag == "Player")
  //    {
  //        SpawnCollectible();
  //        Destroy(gameObject);
  //    }
  //}

    public void collectGift()
    {
        AudioSource.PlayClipAtPoint(giftCollect, transform.position, 1f);
        SpawnCollectible();
        Destroy(gameObject);
    }

    void SpawnCollectible()
    {
        Instantiate(collectibleToSpawn, transform.position, collectibleToSpawn.transform.rotation);
        Destroy(gameObject);
    }
}