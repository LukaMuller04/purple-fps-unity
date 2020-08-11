using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFor : MonoBehaviour
{
    public float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

          if (transform.position.z > 10)
        {
            Destroy(gameObject);

            
        }  


         if (transform.position.z < -10)
        {
            Destroy(gameObject);

            
        }  

        
    }

      
}
