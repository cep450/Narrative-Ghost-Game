using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class SceneController : MonoBehaviour
{

        //makes stuff happen at the right times. 
        //enables Scenes ie starting them up. 

<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
    public GameObject parent;
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

    public GameObject face_shaun, face_tracy, face_luigi, face_avery, face_preston;



    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("Scenes");
        //just temporary. this would happen at some certain point 
        StartCoroutine(Intro());
        
    }


    [YarnCommand("showFace")]
    public void showFace(string name) {
        if(name.Equals("Shaun")) {
            face_shaun.SetActive(true);
        } else if(name.Equals("Avery")) {
            face_avery.SetActive(true);
        } else if(name.Equals("Luigi")) {
            face_luigi.SetActive(true);
        } else if(name.Equals("Tracy")) {
            face_tracy.SetActive(true);
        } else if(name.Equals("Preston")) {
            face_preston.SetActive(true);
        }
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
