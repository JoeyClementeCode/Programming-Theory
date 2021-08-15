using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed;
    private float xRange = 10;
    private float zRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        IDog dogInterface = gameObject.GetComponent<IDog>();
        speed = dogInterface.speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Check for left and right bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.x > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }


        // Player movement left to right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // Player movement up and down
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }
}
