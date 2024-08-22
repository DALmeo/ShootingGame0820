using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScroolManeger : MonoBehaviour
{
    List<IbackgroundScroller> backgroundScroolers;


    private float scroolSpeed = 0f;

    private void Start()
    {
        backgroundScroolers = InterfaceFinder.FindObectOfInterface<IbackgroundScroller>();
    }

    private void Update()
    {
        foreach(var scroller in backgroundScroolers)
        {
            if(scroller !=null)
            {
                scroller.Scroll(Time.deltaTime);
            }
        }
    }
    public void SetScrollSpeed(float newSpeed)
    {
        foreach(var scroller in backgroundScroolers)
        {
            if(scroller is IbackgroundScroller verticalScroller)
            {
                verticalScroller.SetScrollSpeed(newSpeed);
            }
        }
    }
}
