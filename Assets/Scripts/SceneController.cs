using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class SceneController : MonoBehaviour
{

    //makes stuff happen at the right times. 
    //enables Scenes ie starting them up. 


    public GameObject parent = GameObject.Find()
    public GameObject sc_intro; 
    public GameObject sc_dontburn;
    public GameObject sc_puffball;
    public GameObject sc_foodready;
    public GameObject sc_upstairs;
    public GameObject sc_playingmagic;
    public GameObject sc_interrupting;
    public GameObject sc_scarystories;
    public GameObject sc_ending;
    //ect for scenes 



    // Start is called before the first frame update
    void Start()
    {
        //just temporary. this would happen at some certain point 
        StartCoroutine(Intro());
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    IEnumerator Intro() {

        float sec = 3;
        for (float counter = 0; counter < sec; counter += Time.deltaTime)
        {
            yield return null;
        }
        sc_intro.SetActive(true);
    }


    [YarnCommand("enableScene")]
    public void enableNextScene(string seconds, string sceneName) {
        GameObject sc = null;
        if(sceneName.Equals("DontBurnTheHouseDown")) {
            sc = sc_dontburn;
        } else if(sceneName.Equals("FoodsReady")) {
            sc = sc_foodready;
        } else if(sceneName.Equals("CookingThePuffball")) {
            sc = sc_puffball;
        } else if(sceneName.Equals("DoYouWantToGoUpstairs")) {
            sc = sc_upstairs;
        } else if(sceneName.Equals("TheyAreProbablyPlayingMagicInBed")) {
            sc = sc_playingmagic;
        } else if(sceneName.Equals("InterruptingTheMagicGame")) {
            sc = sc_interrupting;
        } else if(sceneName.Equals("ScaryStories")) {
            sc = sc_scarystories;
        } else if(sceneName.Equals("EndingScene")) {
            sc = sc_ending;
        }

        float sec = float.Parse(seconds);
        StartCoroutine(enableNextSceneRoutine(sec, sc));
    }

    IEnumerator enableNextSceneRoutine(float seconds, GameObject sc) {
        yield return new WaitForSeconds(seconds);
        sc.SetActive(true);
    }

    //private IEnumerator TimedScene(Scene scene) {

    //}
}
}
