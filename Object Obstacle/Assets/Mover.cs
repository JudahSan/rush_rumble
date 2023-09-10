using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // TODO: Use SerializeField to make changes in Unity directly
    // [SerializeField] float xMovement = 0;
    // [SerializeField] float yMovement = 0.05f;
    // [SerializeField] float zMovement = 0;
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        GameInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void GameInstructions()
    {
        Debug.Log("Welcome Player");
        Debug.Log("Use WASD, arrow keys or controller to move the player");
        Debug.Log("Don't hit the walls. They're still buggy!!");
    }

    void PlayerMovement()
    {
        float xMovement = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zMovement = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xMovement, 0, zMovement);
    }
}

