using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueFuncs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator pauseThenContinue() {

        //TODO dont do this if we're possessed and making a choice. when to call this? 

        //TODO modulate this based on the length of the line 
        yield return new WaitForSeconds(3);

        //DialogueUI.MarkLineComplete(); 


    }
}
