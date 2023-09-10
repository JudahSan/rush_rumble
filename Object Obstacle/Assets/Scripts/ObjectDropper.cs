using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDropper : MonoBehaviour
{
    // Start is called before the first frame update

    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float dropInterval = 3f;
    public GameObject objectDrop;

    // private float timeSinceLastDrop = 0f;
    void Start()
    {
        // Get rigidbody and render components
        // Reference caching
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    void Update()
    {
        // Elapsed time
        // Debug.Log(Time.time);
        // timeSinceLastDrop += Time.deltaTime;

        // if (timeSinceLastDrop >= dropInterval)
        // {
        //     timeSinceLastDrop = 0f;
        //     Instantiate(objectDrop, transform.position, Quaternion.identity);
        // }

        if (Time.time > dropInterval)
        {
            // Debug.Log(dropInterval + " seconds have elapsed");
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
