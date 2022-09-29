using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum : MonoBehaviour
{
  public backgroundScript backgroundScript1;
  public backgroundScript backgroundScript2;
  public GameObject boat;
  public GameObject hook;
  public float maxSpeed = 500.0f;
  public float minSpeed = 0.0f;
  public float maxLength = 8.0f;
  public float minLength = 1.0f;
  public float boatSpeed = 0.0f;
  public float ropeLength = 1.0f;
  public float boatPower = 50.0f;
  public float winchPower = 4.0f;
  public float difficultyScaler = 1.0f;
  float time = 0.0f;
  LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
      lineRenderer = gameObject.GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        backgroundScript1.backgroundSpeed = boatSpeed/5;
        backgroundScript2.backgroundSpeed = boatSpeed/5;
        lineRenderer.SetPosition(0, boat.transform.position);
        lineRenderer.SetPosition(1, hook.transform.position +Vector3.up);
        hook.GetComponent<Rigidbody>().AddForce(boatSpeed*-1,0,0);
        boat.GetComponent<SpringJoint>().minDistance = ropeLength;
        time+= Time.deltaTime;

        // if (Input.GetKey("a") && boatSpeed > minSpeed)
        // {
        //     boatSpeed -= Time.deltaTime * boatPower;
        // }
        // if (Input.GetKey("d") && boatSpeed < maxSpeed)
        // {
        //     boatSpeed += Time.deltaTime * boatPower;
        // }
        if (Input.GetKey("w") && ropeLength > minLength)
        {
            ropeLength -= Time.deltaTime * winchPower;
        }
        if (Input.GetKey("s") && ropeLength < maxLength)
        {
            ropeLength += Time.deltaTime * winchPower;
        }

        if(time > 1.0f)
        {
          boatSpeed += difficultyScaler;
          time = 0;
        }
    }
}
