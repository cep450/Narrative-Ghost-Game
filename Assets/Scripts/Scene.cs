using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class Scene : MonoBehaviour
{

    public string startNode;

    public YarnProgram scriptBaseline;
    public YarnProgram scriptInteraction;

    public bool possessAvery;
    public bool possessShaun;
    public bool possessTracy;
    public bool possessPreston;
    public bool possessLuigi;

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

/*
    Variable names:
    isShaunPossessed
    isAveryPossessed
    isPrestonPossessed
    isLuigiPossessed
    haunted
    isShaunScared
    isAveryScared
    isTracyScared
    isPrestonScared
*/

    public void possess() {

        Debug.Log("hi from inside possess func");

        //set the yarn haunted variable to true
        variableStorage.SetValue("haunted", 1);

        Debug.Log("haunted is now " + variableStorage.GetValue("haunted"));

        if(possessShaun) {
            variableStorage.SetValue("isShaunPossessed", 1);
            Debug.Log("possessed shaun");
        }
        if(possessAvery) {
            variableStorage.SetValue("isAveryPossessed", 1);
            Debug.Log("possessed avery");
        }
        if(possessPreston) {
            variableStorage.SetValue("isPrestonPossessed", 1);
            Debug.Log("possessed preston");
        }
        if(possessTracy) {
            variableStorage.SetValue("isTracyPossessed", 1);
            Debug.Log("possessed tracy");
        }
        if(possessLuigi) {
            variableStorage.SetValue("isLuigiPossessed", 1);
            Debug.Log("possessed luigi");
        }
        
        //if this is a longer script, we need to translate what node it's on. 
        /*
        if(usingNodes) {
            string nodename = dialogueRunner.Dialogue.currentNode;
            dialogueRunner.Add(scriptInteraction);
            dialogueRunner.StartDialogue(nodename); //TODO naming convention 
        }
        */

        //use Dialogue.currentNode 
        //and SetNode(string)
        //like SetNode(theOldDialogue.currentNode)

        //dialogueRunner.Dialogue.SetNode(nodename);
        

    }
    
}
}
