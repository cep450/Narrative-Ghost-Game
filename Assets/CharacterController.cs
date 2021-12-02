using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private void Start()
    {
        GameEvents.current.onMoveTarget += MoveTarget; 
    }

    [SerializeField]
    public int id;

    //LIST OF PARAMETERS THAT SHOULD GO IN WHICH ORDER:
    /* 1) Character ID
     * 2) Speed
     * 
     * From then on, every two floats you enter will serve as midpoints (ie. one set of coords = straight line, two sets of coords = midpoint + endpoint, etc.) 
     * i'm going to sob
     */
    private void MoveTarget(params float[] param)
    {
        //checking ID; if the ID doesn't match the character, the character doesn't (shouldn't) fuck with the rest of the code. 
        /*ID guide:
         * 0 -- Avery
         * 1 -- Luigi
         * 2 -- Preston
         * 3 -- Shaun
         * 4 -- Tracy
         */

        float id = param[0];
        Debug.Log(id);
        if (id == this.id)
        {
            //get speed
            var speed = param[1];

            //For every two numbers AFTER the id/speed...
            for (int i = 2; i < param.Length; i += 2)
            {
                //get target position
                var targetPosition = new Vector2(param[i], param[i + 1]);
                //get current position
                Vector2 currentPosition = transform.position;
                Debug.Log(currentPosition.x);
                //while those two numbers are not equal...
                while (currentPosition != targetPosition)
                {
                    //advance towards position
                    transform.position = Vector2.Lerp(currentPosition, targetPosition, Time.deltaTime * speed); 
                }
            }
        }
    }
}
