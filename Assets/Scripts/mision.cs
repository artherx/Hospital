using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mision : MonoBehaviour
{
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "objM")
        {
            other.transform.position = new Vector3(4.3f, 1.3f, 3.7f);
        }

    }
}
