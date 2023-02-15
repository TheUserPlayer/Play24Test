using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEndGame : MonoBehaviour
{
    public Player Sticman;
    public Movement move;
    public GameObject wheel;
    private void OnTriggerEnter(Collider other) 
    {
       
       if(other.tag == "RedCub")
      {
        move.EndGame();
        Sticman.EndPlayer();
      }
    }
}
