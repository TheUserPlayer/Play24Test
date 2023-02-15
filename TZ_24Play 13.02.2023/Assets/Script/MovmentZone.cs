using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovmentZone : MonoBehaviour,IPointerDownHandler, IDragHandler, IPointerUpHandler
{
     private Vector2 origin;
    private Vector2 direction;
    private void Awake() 
   {
    direction = Vector2.zero;
   }
   public void OnPointerDown(PointerEventData ecentData)
   {
    origin = ecentData.position;
   }
   public void OnDrag(PointerEventData ecentData)
   {
    Vector2 currentPosition = ecentData.position;
    Vector2 directionRaw = currentPosition - origin;
    direction = directionRaw.normalized;
   }
   public void OnPointerUp(PointerEventData ecentData)
   {
    direction = Vector2.zero;
   }
   public Vector2 GetDirection()
   {
    return direction;
   }
}
