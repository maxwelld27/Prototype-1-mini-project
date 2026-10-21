using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Sphere;
    
    //Move the sphere left and right based on right arrow keys
    public float horizontalInput;
    // Move the car forward based on up and down arrow keys
    public float forwardInput;
    // Create a speed variable for the sphere
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the sphere forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Make the car turn based on left and right arrow keys
       transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
