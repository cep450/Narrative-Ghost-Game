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

    void OnTriggerStay2D(Collider2D other) {
        if(Input.GetKeyDown(KeyCode.E)) {
            myE.enabled = false;

            //if(other.gameObject)
            //TODO get if it's a scene object, if it is, do something with its scene call a function or soemthing 
            //the possess() function i believe 

            /*
            HingeJoint hinge = gameObject.GetComponent(typeof(HingeJoint)) as HingeJoint;

            if (hinge != null)
                hinge.useSpring = false;
            */

            //Scene otherSceneScript = other.gameObject.GetComponent<Scene>() as Scene;

        }

    }

    void OnTriggerExit2D() {
        
        myE.enabled = false;
    }
}
