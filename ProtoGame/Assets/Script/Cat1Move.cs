using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Cat1Move : MonoBehaviour
{
    Vector3 direct;
    // Start is called before the first frame update
    void Start()
    {
        float x = UnityEngine.Random.Range(-2, 2);
        float z = UnityEngine.Random.Range(-2, 2);
        float temp = (float)Math.Sqrt(x * x + z * z);
        GetComponent<Rigidbody>().velocity = new Vector3(x,0,z);
        
    }

    // Update is called once per frame
    void Update()
    {
       float nx = GetComponent<Rigidbody>().velocity.x;
       float nz = GetComponent<Rigidbody>().velocity.z;
       direct = GetComponent<Rigidbody>().velocity;
    }
    void OnCollisionEnter(Collision collision)
    {
        Vector3 incomingVector = direct;
        Vector3 normalVector = collision.contacts[0].normal;
        Vector3 reflectVector = Vector3.Reflect(incomingVector, normalVector);
        GetComponent<Rigidbody>().velocity = reflectVector;
        //direct = GetComponent<Rigidbody>().velocity;

        /* 
         if (other.name==wall1.name)
         {
             GetComponent<Rigidbody>().velocity = new Vector3(nx, 0, -nz);
         } 
         if (other.name == wall2.name)
         {
             GetComponent<Rigidbody>().velocity = new Vector3(-nx, 0, nz);
         }
         if (other.name == wall3.name)
         {
             GetComponent<Rigidbody>().velocity = new Vector3(nx, 0, nz);
         }
         if (other.name == wall4.name)
         {
             GetComponent<Rigidbody>().velocity = new Vector3(-nx, 0, nz);
         }
         */
    }
}
