using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
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
        
    }

    void OnTriggerEnter2D() {
        
        myE.enabled = true;
    }

    void OnTriggerStay2D(Collider2D other) {

        //if can interact, and presses E 
        if(Input.GetKeyDown(KeyCode.E) && myE.enabled) {

            Debug.Log("caught E press");

            Scene sceneOverlapping = other.gameObject.GetComponent<Scene>();
                
            //if overlapping w/ a scene, possess in that scene 
            if(sceneOverlapping != null) {
                sceneOverlapping.possess();
                myE.enabled = false; 
            }

        }

    }

    void OnTriggerExit2D() {
        
        myE.enabled = false;
    }
}
}
