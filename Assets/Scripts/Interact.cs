using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    public SpriteRenderer myE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
                
            //make something happen 

        }

    }

    void OnTriggerEnter2D() {
        
        Debug.Log("got here");

        myE.enabled = true;
    }

    void OnTriggerStay2D() {
        if(Input.GetKeyDown(KeyCode.E)) {
            myE.enabled = false;

        }

    }

    void OnTriggerExit2D() {
        
        myE.enabled = false;
    }
}
