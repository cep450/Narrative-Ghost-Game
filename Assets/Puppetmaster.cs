using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
    public class Puppetmaster : MonoBehaviour
    {

        /////// to get variables from twine-- 
        //variableStorage.GetValue("variableName").AsBool (or AsNumber ect)


        //this is wildly inefficient but that's ok this is fine
        public GameObject Avery;
        public GameObject Shaun;
        public GameObject Tracy;
        public GameObject Preston;
        public GameObject Luigi;


        InMemoryVariableStorage variableStorage;


        /* Basically, the (wildly) ineffective way this code works is that every character should run on their own coroutine timeline. Movements are all manually inserted, then the WaitForSeconds(), then another movement,
         * rinse and repeat. One thing that I am looking to implement is having a "whileTalking" boolean of some sort that pauses the coroutine while the character is in a dialogue state, but that isn't a thing yet. The stuff
         * below is just test code, since I don't have the backgrounds. 
         * Also. Tracy/Preston/Luigi's timelines are commented out but that's just because I copy-pasted Avery's and haven't changed the parameters accordingly. */

        private void Start()
        {
            variableStorage = FindObjectOfType<InMemoryVariableStorage>();

            //StartCoroutine(StartTimeline());
        }

        public void MoveTarget(GameObject obj, float newSpeed, params float[] newCoords)
        {
            var scr = obj.GetComponent<Character>();
            scr.speed = newSpeed;
            scr.coordX = newCoords[0];
            scr.coordY = newCoords[1];
        }

        [YarnCommand("walkTo")]
        public void walkTo(string character, string speed, string destinationName)
        {
            Debug.Log("WalkTo has been run!");
            var floatSpeed = float.Parse(speed);
            var charObj = GameObject.Find(character);
            switch (destinationName)
            {
                case "LuigiEntrance":
                    MoveTarget(charObj, floatSpeed, -7.54f, -1.03f);
                    break;
                case "PrestonEntrance":
                    MoveTarget(charObj, floatSpeed, -7.28f, -0.49f);
                    break;
                case "TracyEntrance":
                    MoveTarget(charObj, floatSpeed, -8.07f, -1.03f);
                    break;
                case "ShaunEntrance":
                    MoveTarget(charObj, floatSpeed, -8.96f, -1.42f);
                    break;
                case "AveryEntrance":
                    MoveTarget(charObj, floatSpeed, -8.58f, -1.47f);
                    break;
                case "LuigiLivingRoom":
                    MoveTarget(charObj, floatSpeed, -4.17f, 0f);
                    break;
                case "PrestonLivingRoom":
                    MoveTarget(charObj, floatSpeed, -2.58f, 0f);
                    break;
                case "TracyLivingRoom":
                    MoveTarget(charObj, floatSpeed, -3.08f, 0.5f);
                    break;
                case "ShaunLivingRoom":
                    MoveTarget(charObj, floatSpeed, -1.57f, 0f);
                    break;
                case "AveryLivingRoom":
                    MoveTarget(charObj, floatSpeed, -5.54f, 0f);
                    break;
                case "PrestonBasement":
                    MoveTarget(charObj, floatSpeed, -5f, -1.5f);
                    break;
                case "LuigiKitchen":
                    MoveTarget(charObj, floatSpeed, 2.8f, 0f);
                    break;
                case "PrestonKitchen":
                    MoveTarget(charObj, floatSpeed, -0.4f, 0f);
                    break;
                case "TracyKitchen":
                    MoveTarget(charObj, floatSpeed, 0.8f, 0f);
                    break;
                case "ShaunKitchen":
                    MoveTarget(charObj, floatSpeed, 0.4f, 0f);
                    break;
                case "AveryKitchen":
                    MoveTarget(charObj, floatSpeed, 3.3f, 0f);
                    break;
                case "LuigiBedroom":
                    MoveTarget(charObj, floatSpeed, 1f, 2.5f);
                    break;
                case "TracyBedroom":
                    MoveTarget(charObj, floatSpeed, 2.1f, 2.5f);
                    break;
                case "ShaunBedroom":
                    MoveTarget(charObj, floatSpeed, -0.3f, 2f);
                    break;
                case "AveryBedroom":
                    MoveTarget(charObj, floatSpeed, -1f, 2f);
                    break;
                case "ShaunDock":
                    MoveTarget(charObj, floatSpeed, 6.4f, -0.85f);
                    break;
                case "AveryDock":
                    MoveTarget(charObj, floatSpeed, 6.74f, -0.85f);
                    break;
            }
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
        }

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

        /*public IEnumerator LuigiTimeline()
        {
            MoveTarget(Luigi, 2, -14, -1);
            while (MoveCheck(Luigi) == true) {
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
        }*/
    }
}
