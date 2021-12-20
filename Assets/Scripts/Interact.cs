using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class Interact : MonoBehaviour
{

    public SpriteRenderer myE;

    public AudioClip possessSfx;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        myE.enabled = true;

        //if can interact, and presses E 
        if(Input.GetKeyDown(KeyCode.E) && myE.enabled) {

            Debug.Log("caught E press");

            Scene sceneOverlapping = other.gameObject.GetComponent<Scene>();
                
            //if overlapping w/ a scene, possess in that scene 
            if(sceneOverlapping != null) {
                sceneOverlapping.possess();
                myE.enabled = false; 
                source.PlayOneShot(possessSfx);
            }

        }
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
                source.PlayOneShot(possessSfx);
            }

        }

    }

    void OnTriggerExit2D() {
        
        myE.enabled = false;
    }
}
}
