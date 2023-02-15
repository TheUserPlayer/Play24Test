using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Animator anim;
    public Transform original;
    public Transform parent;
    public Transform spawnPoint;
    public Transform spawnPointPar;
    public Transform par;
    public Rigidbody rb; 
    public float acceleration;
    public float invokeTime;
    public Vector2 direction;
    public GameObject EndPanel;

    private void Start() 
    {
      //Time.timeScale= 0;
     anim = GetComponent<Animator>();
    
     
      
    }
    public void SpawnCub()
    { 
          Debug.Log("good");
          anim.Play("Jumping");
          rb.AddForce(direction.normalized * acceleration,ForceMode.Impulse);
          Invoke("InvokeInstantiateCub",invokeTime); 
          var childPar = Instantiate( par, spawnPointPar.position,transform.rotation);  
    }
    private void InvokeInstantiateCub()
    {
      var child = Instantiate( original, spawnPoint.position,transform.rotation);
      
      child.SetParent(parent);
    }
    public void EndPlayer()
    {
      Debug.Log("SticmanEndS");
      anim.Play("End");
      EndPanel.SetActive(true);
    }
    public void RestartLevl()
    {
        SceneManager.LoadScene("PLAY24Game");
    }
    
   
}
