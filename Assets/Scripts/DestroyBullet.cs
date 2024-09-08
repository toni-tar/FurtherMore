using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Destroyer"))

        {
            Destroy(gameObject);
        }
       else if (other.gameObject.CompareTag("Player"))
        {

            other.gameObject.transform.localScale -= new Vector3(766f, 667f, 676f);  
            
            
            Destroy(gameObject); 
        
        

        } 





    }


}
