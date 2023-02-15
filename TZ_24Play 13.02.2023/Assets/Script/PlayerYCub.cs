using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerYCub : MonoBehaviour
{
  
    public Player Player;
    private void OnTriggerEnter(Collider other) 
    {
      if(other.tag == "YellowCub")
      {
        Player.SpawnCub();
      }  
      
    }
    
}
