using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveTriggers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.MoveTarget(0, 1, 20, 20);
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
