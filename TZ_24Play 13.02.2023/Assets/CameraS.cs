using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraS : MonoBehaviour
{
   public Transform Car;
    public Vector3 Off;
   
    void Update()
    {
        transform.position = new Vector3(Off.x,Off.y, Car.position.z + Off.z);
    }
}
