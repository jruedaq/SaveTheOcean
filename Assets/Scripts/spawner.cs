using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] entities;
    public List<entity> entityList = new List<entity>();
    float time = 0.0f;
    public backgroundScript backgroundScript;

    // Start is called before the first frame update
    void Start()
    {
      entities = Resources.LoadAll<GameObject>("Prefabs") as GameObject[];
      foreach (GameObject i in entities)
      {
          switch(i.name)
          {
            case "fish":
              entityList.Add(new entity(50, 0, true, i));
              break;
            case "plastic":
              entityList.Add(new entity(150, 250, false, i));
              break;
            default:
              Debug.Log("unknown prefab");
              break;
          }
      }
    }

    Vector3 RandomPos()
    {
      float x;
      float y;
      float z;
      Vector3 pos;
      x = Random.Range(11, 20);
      y = Random.Range(-3, 3);
      z = -1;
      pos = new Vector3(x, y, z);
      return pos;
    }

    // Update is called once per frame

    void Update()
    {
      time += Time.deltaTime;
      if(time > 0.1)
      {
        time = 0;
        Vector3 pos = RandomPos();
        foreach (entity ent in entityList)
        {
          if(ent.rarity > Random.Range(0,1000))
          {
            GameObject obj = Instantiate(ent.gameObject, pos, Quaternion.identity);
            obj.GetComponent<Rigidbody>().AddForce(backgroundScript.backgroundSpeed*-50,0,0);
          }

        }

      }

    }
}

[System.Serializable]
public class entity
{ //box collider center, x = worth, y = enemy - 0 for false and 1 for true
  public GameObject gameObject;
  public int rarity;
  public int worth;
  public bool enemy;
  public entity (int prarity, int pworth, bool penemy, GameObject pgameObject)
  {
    gameObject = pgameObject;
    rarity = prarity;
    worth = pworth;
    enemy = penemy;
    int enemyInt = enemy ? 1 : 0;
    gameObject.GetComponent<BoxCollider>().center = new Vector3(worth, enemyInt, 0);
  }
}
