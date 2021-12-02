using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class Scene : MonoBehaviour
{

    public string startNode;

    public YarnProgram scriptBaseline;
    public YarnProgram scriptInteraction;

    public bool usingNodes;

    DialogueRunner dialogueRunner;

    InMemoryVariableStorage variableStorage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //will happen when the SceneController enables me. 
    //cue to start this scene and its dialogue. 
    void OnEnable() {

        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        dialogueRunner.StartDialogue(startNode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void possess() {


        //set the yarn haunted variable to true
        variableStorage.SetValue("haunted", true);
        
        
        //if this is a longer script, we need to translate what node it's on. 
        if(usingNodes) {
            string nodename = dialogueRunner.Dialogue.currentNode;
            dialogueRunner.Add(scriptInteraction);
            dialogueRunner.StartDialogue(nodename); //TODO naming convention 
        }


        /*

            // Store a value into a variable
            public virtual void SetValue(string variableName, Yarn.Value value) {
                // 'variableName' is the name of the variable that 'value' 
                // should be stored in.
            }

            // Return a value, given a variable name
            public virtual Yarn.Value GetValue(string variableName) {
                // 'variableName' is the name of the variable to return a value for
            }

            // Return to the original state
            public virtual void ResetToDefaults () {

            }

        */

        //use Dialogue.currentNode 
        //and SetNode(string)
        //like SetNode(theOldDialogue.currentNode)

        //dialogueRunner.Dialogue.SetNode(nodename);
        

    }
    
}
}