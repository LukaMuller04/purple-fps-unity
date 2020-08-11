using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
   

    public GameObject[] targets;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnObject", 0.10f, 2f);
    }

    // Update is called once per frame
 void SpawnObject()
 {
     float x = Random.Range(-10f, 10f);
    float z = Random.Range(-170f, 170f);
    int enemyIndex = Random.Range(0, targets.Length);
     Instantiate(targets[enemyIndex], new Vector3(x,0,z), Quaternion.identity);
 }   
}
