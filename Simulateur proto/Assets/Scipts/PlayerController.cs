using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float thrust = 22000f;
    private float turnSpeed = 4f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody rb;
    [SerializeField] private GameObject PointG;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = PointG.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Move the vehicle forward

        rb.AddRelativeForce(Vector3.forward * thrust * forwardInput);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput);
    }
}