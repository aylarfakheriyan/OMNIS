using UnityEngine;
using System;
using System.Collections.Generic;

public class MainThreadDispatcher : MonoBehaviour
{
    static readonly Queue<Action> actions = new Queue<Action>();

    static MainThreadDispatcher instance;

    [RuntimeInitializeOnLoadMethod]
    static void Initialize()
    {
        if (instance != null)
            return;

        GameObject obj =
            new GameObject("MainThreadDispatcher");

        DontDestroyOnLoad(obj);

        instance =
            obj.AddComponent<MainThreadDispatcher>();
    }

    public static void Run(Action action)
    {
        lock (actions)
        {
            actions.Enqueue(action);
        }
    }

    void Update()
    {
        lock (actions)
        {
            while (actions.Count > 0)
            {
                actions.Dequeue()?.Invoke();
            }
        }
    }
}