using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace Yarn.Unity {
public class SceneController : MonoBehaviour
{

    //makes stuff happen at the right times. 
    //enables Scenes ie starting them up. 


    public GameObject sc_intro; 
    public GameObject sc_puffball;
    //ect for scenes 



    // Start is called before the first frame update
    void Start()
    {
        //just temporary. this would happen at some certain point 
        sc_intro.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {


    }

    //private IEnumerator TimedScene(Scene scene) {

    //}
}
//}
