using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Myjoystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Transform handle;
    private Transform pivot;
    private float distance;
    private Vector2 direction;
    public Vector2 Direction => direction;
    private void Awake()
    {
        Initjoystick();   
    }
    public void Initjoystick()
    {
        handle = transform.Find("Handel");
        pivot = transform.Find("pivot");
    }
    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }
}
