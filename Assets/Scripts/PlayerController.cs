using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private int speed = 7;
    private int rotationSpeed = 30;
    private float horizontal;
    private float vertical;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);
        /*if (Input.GetKey(KeyCode.W))
        { 
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    */
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("пельмени приготовились");  
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Пельмени съел шлёпа");
    }
}

