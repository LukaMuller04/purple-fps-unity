using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movenment : MonoBehaviour
{
   public float speed;
   public float turnSpeed;
   public float horizontalInput;
   public float verticalInput;

 
    void Start()
    { 

;
    }

    
    void Update()
    { 
 verticalInput = Input.GetAxis("Vertical");
horizontalInput = Input.GetAxis ("Horizontal");
transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}