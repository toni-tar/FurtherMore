using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public GameObject bullet;
     public Transform[] bullets;

   private void Start()
    {
     foreach (Transform weaponShels in bullets)
        {
            StartCoroutine(SpawnObject(weaponShels));
        } 
            
    }
   private IEnumerator SpawnObject(Transform weaponShels)
    {
        while (true)
        { 

        Instantiate(bullet, weaponShels.position,weaponShels.rotation);
            yield return new WaitForSeconds(2);

                }
    } 

        
    

}
