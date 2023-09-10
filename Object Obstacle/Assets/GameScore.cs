using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    int collisions = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        collisions++;
        Debug.Log("Mayday Mayday!! Collision Detected!! " + collisions + " hits recorded");
    }
}
