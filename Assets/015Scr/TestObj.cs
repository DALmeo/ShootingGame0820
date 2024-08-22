using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObj : MonoBehaviour,IbackgroundScroller
{
    public void ResetPosition()
    {
        transform.position = new Vector3(0f, 8f, 0f);
    }

    public void Scroll(float deltaTime)
    {
        transform.position += Vector3.down * 2f * Time.deltaTime;
        if(transform.position.y < -8f)
            ResetPosition();
    }

    public void SetScrollSpeed(float newSpeed)
    {

    }

   
}
