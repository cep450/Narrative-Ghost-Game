using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity
{
    public class Character : MonoBehaviour
    {
        public float speed;
        public float coordX;
        public float coordY;
        bool isMoving;

        private Vector3 lastUpdatePos = Vector3.zero;
        private Vector3 dist;

        Rigidbody2D rb2d;

        private void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        public void MoveTarget(GameObject obj, float newSpeed, string target)
        {
            var scr = obj.GetComponent<Character>();
            var targetObj = GameObject.Find(target);
            scr.speed = newSpeed;
            scr.coordX = targetObj.transform.position.x;
            scr.coordY = targetObj.transform.position.y;
        }

        [YarnCommand("walkTo")]
        public void walkTo(string character, string speed, string destinationName)
        {
            Debug.Log("WalkTo has been run!");
            var floatSpeed = float.Parse(speed);
            var charObj = GameObject.Find(character);

            MoveTarget(charObj, floatSpeed, destinationName);
        }


        //Each character constantly moves towards its destination. 
        private void Update()
        {
            MoveTo(speed, coordX, coordY);
            MoveCheck();
        }

        public void MoveTo(float speed, params float[] coords)
        {
            for (int i = 0; i < coords.Length; i += 2)
            {
                Vector2 currentPos = new Vector2(transform.position.x, transform.position.y);
                Vector2 targetPos = new Vector2(coords[i], coords[i + 1]);

                if (Vector2.Distance(currentPos, targetPos) > 0.1)
                {
                    transform.position = Vector2.MoveTowards(currentPos, targetPos, speed * Time.deltaTime);
                }
            }
        }

        public bool MoveCheck()
        {
            dist = transform.position - lastUpdatePos;
            lastUpdatePos = transform.position;
            if (dist.magnitude == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}