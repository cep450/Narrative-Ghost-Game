using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    float MAX_POS_X = 20f;
    float MAX_POS_Y = 20f;
    static float SPEED = 0.05f;
    float SPEED_DIAG = SPEED * Mathf.Sin(Mathf.PI / 4) + 0.002f;

    Vector3 faceright = new Vector3(1, 1, 1);
    Vector3 faceleft = new Vector3(-1, 1, 1);

    // Update is called once per frame
    void Update()
    {

        //only check key once
        bool up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        bool left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        float effectivespeed;

        //same speed when diagonal
        if((up || down ) && (left || right)) {
            effectivespeed = SPEED_DIAG;
        } else {
            effectivespeed = SPEED;
        }

        //prevent from going out of bounds
        if(up && transform.position.y < MAX_POS_Y) {
            transform.Translate(0f, effectivespeed, 0f);
        }
        if(down && transform.position.y > -MAX_POS_Y) {
            transform.Translate(0f, -effectivespeed, 0f);
        }
        if(left && transform.position.x > -MAX_POS_X) {
            transform.Translate(-effectivespeed, 0f, 0f);
        }
        if(right && transform.position.x < MAX_POS_X) {
            transform.Translate(effectivespeed, 0f, 0f);
        }

        //flip sprite 
        if(right) {
            transform.localScale = faceright;
        } else if(left) {
            transform.localScale = faceleft;
        }

    }
}