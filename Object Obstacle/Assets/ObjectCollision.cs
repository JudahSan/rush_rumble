using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log("Mama, just hit a wall!!!");
        // Change appearance when a collision action is triggered
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
