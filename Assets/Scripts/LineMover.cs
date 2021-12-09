using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class LineMover : MonoBehaviour
{

    public DialogueUI dialogueUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startWaitNextLine() {
        StartCoroutine(waitNextLine());
    }

    public IEnumerator waitNextLine() {
        yield return new WaitForSeconds(1);
        dialogueUI.MarkLineComplete();

    }
}
}
