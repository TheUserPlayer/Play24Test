using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePickup : MonoBehaviour
{
     public GameObject wheel;
     public CameraS cam;
    private void OnTriggerEnter(Collider other) 
    {
       
       if(other.tag == "RedCub")
      {
        cam.SakeAnim();
        wheel.transform.parent = null;
      }
    }
}
