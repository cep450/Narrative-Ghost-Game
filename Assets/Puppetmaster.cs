using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class Puppetmaster : MonoBehaviour
{

    /////// to get variables from twine-- 
    //variableStorage.GetValue("variableName").AsBool (or AsNumber ect)


    //this is wildly inefficient but that's ok this is fine
    public Character Avery;
    public Character Shaun;
    public Character Tracy;
    public Character Preston;
    public Character Luigi; 


    InMemoryVariableStorage variableStorage;


    /* Basically, the (wildly) ineffective way this code works is that every character should run on their own coroutine timeline. Movements are all manually inserted, then the WaitForSeconds(), then another movement,
     * rinse and repeat. One thing that I am looking to implement is having a "whileTalking" boolean of some sort that pauses the coroutine while the character is in a dialogue state, but that isn't a thing yet. The stuff
     * below is just test code, since I don't have the backgrounds. 
     * Also. Tracy/Preston/Luigi's timelines are commented out but that's just because I copy-pasted Avery's and haven't changed the parameters accordingly. */

    private void Start()
    {
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();

        StartCoroutine(StartTimeline());
    }

    public void MoveTarget(Character obj, float newSpeed, params float[] newCoords)
    {
        obj.speed = newSpeed;
        obj.coordX = newCoords[0];
        obj.coordY = newCoords[1]; 
    }

    bool MoveCheck(Character obj)
        {
            return obj.MoveCheck(); 
        }

    /*public IEnumerator AveryTimeline()
    {
        MoveTarget(Avery, 4, 3, 3);
        yield return new WaitForSeconds(3);
        MoveTarget(Avery, 7, -3, -7);
    }*/

    public IEnumerator ShaunTimeline()
    {
        MoveTarget(Shaun, 2, -21, -4);
        yield return new WaitForSeconds(4);
        MoveTarget(Shaun, 2, -14, -1);
        yield return new WaitForSeconds(5);
        MoveTarget(Shaun, 2, -4, -1);
    }

   /* public IEnumerator TracyTimeline()
    {
        MoveTarget(Avery, 4, 3, 3);
        yield return new WaitForSeconds(3);
        MoveTarget(Avery, 7, -3, -7);
    }

    public IEnumerator PrestonTimeline()
    {
        MoveTarget(Avery, 4, 3, 3);
        yield return new WaitForSeconds(3);
        MoveTarget(Avery, 7, -3, -7);
    }*/

    public IEnumerator LuigiTimeline()
    {
        MoveTarget(Luigi, 2, -14, -1);
        while (MoveCheck(Luigi) == false) {
                yield return null; 
            }
        MoveTarget(Luigi, 2, -2, -1);
        yield return new WaitForSeconds(6);
    }

    public IEnumerator StartTimeline()
        {
            Coroutine a = StartCoroutine(LuigiTimeline());
            Coroutine b = StartCoroutine(ShaunTimeline());

            yield return a;
            yield return b;
        }
}
}
