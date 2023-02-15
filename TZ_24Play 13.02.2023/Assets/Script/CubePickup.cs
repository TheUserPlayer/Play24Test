using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePickup : MonoBehaviour
{
     public GameObject wheel;
    private void OnTriggerEnter(Collider other) 
    {
       
       if(other.tag == "RedCub")
      {
        
        wheel.transform.parent = null;
      }
    }
}
