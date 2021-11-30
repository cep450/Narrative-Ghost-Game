using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class Scene : MonoBehaviour
{

    public string startNode;

    public YarnProgram scriptBaseline;
    public YarnProgram scriptInteraction;

    DialogueRunner dialogueRunner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //will happen when the SceneController enables me. 
    //cue to start this scene and its dialogue. 
    void OnEnable() {

        //load the script 
        /*
        if (scriptBaseline != null) {
            dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
            dialogueRunner.Add(scriptBaseline);              
        }
        */

        //kick off the dialogue in the scene 
        FindObjectOfType<DialogueRunner>().StartDialogue(startNode);
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
    
}
}
