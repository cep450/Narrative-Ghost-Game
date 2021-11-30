using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace Yarn.Unity {
public class SceneController : MonoBehaviour
{

    //makes stuff happen at the right times. 
    //enables Scenes ie starting them up. 


    public GameObject sc_intro; 
    public int sc_intro_delay;


    float tracker = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tracker += Time.deltaTime;
        if(tracker > sc_intro_delay) {
            sc_intro.SetActive(true);
        }
    }

    //private IEnumerator TimedScene(Scene scene) {

    //}
}
//}
