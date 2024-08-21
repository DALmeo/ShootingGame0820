using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Inst { get; private set; } 

    protected virtual void Awake()
    {
        if(Inst == null)
        {
            Inst = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        DoAwake();
    }
    protected virtual void DoAwake() { }
}

public class SingletonDestroy<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Inst { get; private set; }

    protected virtual void Awake()
    {
        if(Inst == null)
        {
            Inst = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
        DoAwake();
    }
    protected virtual void DoAwake() { }
}
