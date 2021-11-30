using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity.Example {
public class Scene : MonoBehaviour
{

    public YarnProgram scriptBaseline;
    public YarnProgram scriptInteraction;

    DialogueRunner dialogueRunner;

    // Start is called before the first frame update
    void Start()
    {
        if (scriptBaseline != null) {
            dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
            dialogueRunner.Add(scriptBaseline);                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void possess() {

        //TODO get to the line the other one was at 
        //maybe add variables keeping track of line 
        //research if swithcing between files is the right thing to do 

        //use Dialogue.currentNode 
        //and SetNode(string)
        //like SetNode(theOldDialogue.currentNode)
        //DialogueRunner.Dialogue 

        //dialogueRunner.Dialogue.SetNode(nodename);
        
        
        string nodename = dialogueRunner.Dialogue.currentNode;
        dialogueRunner.Add(scriptInteraction);
        dialogueRunner.StartDialogue(nodename);
        
        
        /*
        FindObjectOfType<DialogueRunner> ().StartDialogue (target.talkToNode);
        */
        

    }

    public void enableScene() {
        //TODO set the collider enabled basically 
    }

    
}
}
