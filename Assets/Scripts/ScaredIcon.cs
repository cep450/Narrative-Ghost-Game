using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yarn.Unity {
public class ScaredIcon : MonoBehaviour
{

    //TODO: update ui sprites when scared variable changes. 

    public string myScaredVariableName;
    public GameObject normalImg;
    public GameObject scaredImg;
        
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
                scaredImg.SetActive(true);
                normalImg.SetActive(false);
        }
    }
}
}
