using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        //transform.Translate(0.5f, 0f, 0f);
        //Move ship to the right with both D and right key.
       /* if (Input.GetKey("right"))
        {
            //transform.Translate(0.5f, 0f, 0f);
            //transform.Translate(height, speed * Time.deltaTime, depth);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, height, depth);
        }*/

        //Move ship to left, both A and left key.
        /*if (Input.GetKey("left"))
        {
            transform.Translate(-speed * Time.deltaTime, height, depth);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, height, depth);
        }

        if(!(transform.position.x == 0) && !Input.anyKey)
        {
            transform.Translate(-speed * Time.deltaTime, height, depth);
            if (transform.position.x < 0)
                transform.Translate(0, height, depth);
        }*/

    }
}
