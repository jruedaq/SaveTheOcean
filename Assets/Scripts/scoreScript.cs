using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public int scoreValue = 0;
    public float timePlayed = 0.0f;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
      timePlayed += Time.deltaTime;
        score.text = "Score: " + scoreValue;
    }
}
