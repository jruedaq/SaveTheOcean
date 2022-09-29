using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour
{

    public float backgroundSpeed = 0.0f;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        //Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb2d = GetComponent<Rigidbody2D>();

        //Start the object moving.
        rb2d.velocity = new Vector2(backgroundSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Start the object moving (- because it moves backwards).
        rb2d.velocity = new Vector2(-backgroundSpeed, 0);

    }

}
