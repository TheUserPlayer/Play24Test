using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraS : MonoBehaviour
{
  public Animator anim ;
  private void Start() {
    anim = GetComponent<Animator>();
  }
  public void SakeAnim()
  {
    Debug.Log("Cam");
    anim.Play("cameraShak");
  }
}
