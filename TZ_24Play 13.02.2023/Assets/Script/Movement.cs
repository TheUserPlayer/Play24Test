using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    public Vector3 PlayerPos;
    //private Vector3 touch;
    //private Vector2 _startPos;
    //private float posX;
    //private float posY;
    private float _speed = 0;
    private readonly float _speedTouch = 6f;
    public GameObject Text;
    public GameObject ButtonPlay;
    //[SerializeField] private GameObject player;
    public MovmentZone Zone;
   
    private void FixedUpdate() 
    {
        Vector2 direction = Zone.GetDirection();
        transform.Translate(PlayerPos * _speed *Time.fixedDeltaTime);
        GetComponent<Rigidbody>().velocity = new Vector3(direction.x, 0f, 0f) *_speedTouch;
        
    }
    /*public void Update() 
    {
        
        /*if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    _startPos = touch.position - _startPos;
                    break;

                case TouchPhase.Moved:
                    var dir = touch.position - _startPos;
                    var pos =  new Vector3(dir.x, transform.position.y, transform.position.y);
                    transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * _speedTouch);
                    break;
            }
        }
        /*if (Input.GetMouseButton(0)) /
        {
            posX = Input.mousePosition.x; //x
            posY = Input.mousePosition.y; //y

            player.transform.position =
                Camera.main.ScreenToWorldPoint(new Vector3(posX,0,0)); 
            player.transform.position = new Vector3(player.transform.position.x * _speedTouch * Time.deltaTime, 0, 0); //строчка выше координату z указывала как -10, поэтому вот так фиксю
        }*/
    
    public void Speed()
    {
        _speed = 1;
        Text.SetActive(false);
        ButtonPlay.SetActive(false);
    }
    public void EndGame()
    {
        _speed = 0;
    }

    }
  
                
 

   
    


