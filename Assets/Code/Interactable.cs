using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

  //public void UpdatePlayerInteractable(Player thePlayer)
  //{
  //    thePlayer.UpdateInteractable(this);
  //}
  //
  //public void RemovePlayerInteractable(Player thePlayer)
  //{
  //    thePlayer.UpdateInteractable(null);
  //}

    public void Interact(Player thePlayer)
    {
        Debug.Log(gameObject.name + "was interacted");
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
