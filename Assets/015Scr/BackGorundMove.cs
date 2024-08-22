using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IbackgroundScroller
{
    void Scroll(float deltaTime);
    void ResetPosition();
    void SetScrollSpeed(float newSpeed);
}
public class BackGorundMove : MonoBehaviour , IbackgroundScroller
{
    [SerializeField]
    float scrollSpeed = 0f;
    private Vector3 startPos = new Vector3(0f,12.75f,0f);
    private float resetPositionY = -12.75f;
    public void ResetPosition()
    {
        transform.position = startPos;
    }

    public void Scroll(float deltaTime)
    {
        transform.position += Vector3.down * scrollSpeed * Time.deltaTime;
        if(transform.position.y <  resetPositionY)
        {
            ResetPosition();
        }
    }

    public void SetScrollSpeed(float newSpeed)
    {
        scrollSpeed = newSpeed;
    }

    
}
