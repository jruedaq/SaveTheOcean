using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "destroy")
        {
            Destroy(other.gameObject);
        }
    }
}
