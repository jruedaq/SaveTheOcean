using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endOfGame : MonoBehaviour
{
    public GameObject image;
    public GameObject endText;
    public GameObject button;
    Text health;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }

    public void EndGame(int points, int Survivetime)
    {
      Debug.Log("hi from EndGame in endOfGame");
      health = endText.GetComponent<Text>();
      health.text = "Well done! youve managed to get rid of alot of stuff! infact, our arbitrary point systems says that you've got " + points + " points after playing for " + Survivetime + " seconds";
      image.SetActive(true);
      button.SetActive(true);

    }
    public void ChangeToMenu()
    {
      SceneManager.LoadScene(0);
    }
}
