using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCub : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other) 
    {
      if(other.tag == "Player")
      {
        Debug.Log("!");
        Invoke("Destroy",0.1f) ;
        
      }  
    }
    private void Destroy()
    {
      Destroy(gameObject);
    }
}
