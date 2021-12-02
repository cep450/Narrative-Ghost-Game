using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class ScaredIcon : MonoBehaviour
{

    //TODO: update ui sprites when scared variable changes. 

    public string myScaredVariableName;
    //public something scaredImg;

    InMemoryVariableStorage variableStorage;

    // Start is called before the first frame update
    void Start()
    {
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }

    // Update is called once per frame
    void Update()
    {
        if(variableStorage.GetValue(myScaredVariableName).AsBool) {
            //TODO change ui sprite displayed 
        }
    }
}
}
