using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuntionTimer
{
    public static FuntionTimer Create(Action action, float timer)
    {
        FuntionTimer funtionTimer = new FuntionTimer(action,timer);
        GameObject gameObject = new GameObject("FuntionTimer", typeof(MonoBehaviourHook));
        gameObject.GetComponent<MonoBehaviourHook>().onUpdate = funtionTimer.Update;
        return funtionTimer;
    }

    private class MonoBehaviourHook: MonoBehaviour
    {
        public Action onUpdate;
        private void Update()
        {
            if(onUpdate != null) onUpdate();
        }
    }

    private Action action;
    private float time;

    public FuntionTimer(Action action, float timi)
    {
        this.action = action;
        this.time = timi;
    }

    public void Update()
    {
        time -= Time.deltaTime;
        if(time < 0)
        {
            action();
        }
    }
}
