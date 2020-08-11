using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{

    public GameObject Muzzle2;
    public GameObject Muzzle1;
public float topbound = 10f;

    public GameObject Bullet2;
    public GameObject Bullet1;
    
    public GameObject gun2;
    public GameObject gun1;


    public void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {

            Instantiate( Muzzle2, gun2.transform.position, gun2.transform.rotation);
            Debug.Log(Input.mousePosition);

            Instantiate( Bullet2, gun2.transform.position, gun2.transform.rotation);
            Debug.Log(Input.mousePosition);
        }   




        if (Input.GetButtonDown("Fire1"))
        {

            Instantiate( Muzzle1, gun1.transform.position, gun1.transform.rotation);
            Debug.Log(Input.mousePosition);


            

            Instantiate( Bullet1, gun1.transform.position, gun1.transform.rotation);
            Debug.Log(Input.mousePosition);
        }



       
}
}