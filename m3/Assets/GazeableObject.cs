﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeableObject : MonoBehaviour
{
    

    public virtual void OnGazeEnter(RaycastHit hitInfo)
    {
        Debug.Log("Rayo ENTRA a " + gameObject.name);
    }

    public virtual void OnGaze(RaycastHit hitInfo)
    {
        Debug.Log("Rayo SOBRE a " + gameObject.name);
    }

    public virtual void OnGazeExit()
    {
        Debug.Log("Rayo EXIT a " + gameObject.name);
    }

    public virtual void OnPress(RaycastHit hitInfo)
    {
        Debug.Log("Rayo PRESS a " + gameObject.name);
    }

    public virtual void OnHold(RaycastHit hitInfo)
    {
        Debug.Log("Rayo HOLD a " + gameObject.name);
    }

    public virtual void OnRelease(RaycastHit hitInfo)
    {
        Debug.Log("Rayo RELEASE a " + gameObject.name);
    }
}
