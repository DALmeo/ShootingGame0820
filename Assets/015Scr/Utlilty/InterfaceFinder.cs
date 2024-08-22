using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceFinder : MonoBehaviour
{
    public static List<T> FindObectOfInterface<T>() where T : class
    {
        MonoBehaviour[] allObjects = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None);
        List<T> interfaceObjects = new List<T>();
        foreach (var obj in allObjects)
        {

            if(obj is T)
            {

            }
            if (obj is T interfaceObj)
            {
                interfaceObjects.Add(interfaceObj);
            }
        }
        return interfaceObjects;
    }
}

