using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    // The Puppetmaster object is what instructs all the character objects on what to do. The characters do not have autonomy, and are largely controlled by this object to make things easier.
    // It certainly isn't optimal, but for a game of this scale, I don't think it *reallllly* matters? Plus, like. Time crunch. And all that shit. 

    public static GameEvents current;
    
    private void Awake()
    {
        current = this; 
    }

    public event Action<float[]> onMoveTarget; 
    public void MoveTarget(params float[] param)
    {
        if (onMoveTarget != null)
        {
            onMoveTarget(param);
        }
    }    
}
