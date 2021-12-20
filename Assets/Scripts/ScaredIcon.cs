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

    [YarnCommand("flipSprite")]
    public void flipSprite() {
        scaredImg.SetActive(true);
        normalImg.SetActive(false);
    }

    void OnEnable() {
        StartCoroutine(enableRoutine());
    }

    IEnumerator enableRoutine() {

        float amountToTranslate = 300f;
        float deltaMult = 1f;

        Vector3 pos = transform.position; 
        
        //transform.Translate(0, amountToTranslate, 0);

        //-2(x)(x-1.5)
        //0 thorugh 1
        for(float tracker = 0; tracker < 1; tracker += Time.deltaTime * deltaMult) {
            float x = tracker;
            float y = -2 * (x) * (x - 1.5f);
            transform.position = new Vector3(pos.x, pos.y + amountToTranslate - (amountToTranslate * y), pos.z);
            yield return null;
        }
         
    }
}
}
