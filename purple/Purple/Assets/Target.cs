using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float speed = 10f;
    public bool trigered = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void  Update()
    {
          

         if (trigered == true)
         {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
         }

         
         if (trigered == false)
         {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
         }
    }

    /* private void OnTriggerEnter(Collider other)
    {
        
           Debug.Log("Collision Detected");
           trigered = true;
    }

   */



   private void OnTriggerEnter(Collider theCollision)
     {
     
     if (theCollision.tag == "left")
     {

        Debug.Log("Collision Detected");
        trigered = true;
     }


     if (theCollision.tag == "Right")
     {

        Debug.Log("Collision Detected");
        trigered = false;
     }
     
     
     }

    }


    

