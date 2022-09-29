using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingBackground : MonoBehaviour
{

    private float length = 29.9519f; //Magic number for background length
    //private float length;
    private BoxCollider2D groundCollider; 
    // Start is called before the first frame update
    void Start()
    {
        //Get and store a reference to the collider2D attached to Ground.
        groundCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if we are in the middle of frame two, move other frame in front.
        if (transform.position.x < -length)
        {
            RepositionBackground();
        }

    }

    //For looping background
    private void RepositionBackground()
    {
        //moves the frame the length of the background times 2.
        Vector2 groundOffSet = new Vector2(length * 2f, 0);

        //Changes position.
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
