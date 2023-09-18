using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float Thrustforce = 1000.0f;
    public float Rotationforce = 50.0f;

    [Header("Cached References")]
    public Rigidbody myRigidbody = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        ProscessThrust();
        ProssesRotation();
    } 

    void ProscessThrust()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            myRigidbody.AddRelativeForce(Vector3.up * Thrustforce * Time.deltaTime);
        }
        else
        {

        }
    }

    void ProssesRotation()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
        {
            ApplyRotation(1.0f);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            ApplyRotation(-1.0f);
        }
    }

    private void ApplyRotation(float aRotationDiraction)
    {
        myRigidbody.freezeRotation = true;
        transform.Rotate(Vector3.forward * Rotationforce * Time.deltaTime * aRotationDiraction);

    }
}
