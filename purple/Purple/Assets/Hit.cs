using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEfects : MonoBehaviour
{

      public GameObject FireBulletPow;
      public GameObject SkullBulletPow;
    private void OnTriggerEnter(Collider theCollision)
     {
     
     if (theCollision.tag == "FireBullet")
     {



           Debug.Log("Hit!");
           Instantiate(FireBulletPow,transform.position,  Quaternion.identity);
           
     }


     if (theCollision.tag == "SkullBullet")
     {


            Debug.Log("Hit!");

           Instantiate(SkullBulletPow, transform.position,  Quaternion.identity);
           
     }

}
}