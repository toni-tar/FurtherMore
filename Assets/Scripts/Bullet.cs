using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
 private float speed = 4.0f;
    
        
    

    void Update()
    {
      transform.Translate(Vector3.up * Time.deltaTime * speed);  
    }
}
