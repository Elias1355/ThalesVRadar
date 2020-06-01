using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="IM")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
