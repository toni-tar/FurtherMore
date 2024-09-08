using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Barrier"))
        {
            Debug.Log("Пельмени сварились!!!!!");
            transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
        }
        if (collision.gameObject.CompareTag("Height"))
        {
            Debug.Log("Пельмени поданы!");
            transform.localScale += new Vector3(0.4f, 0.4f, 0.4f);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Small"))
        {
            Debug.Log("Пельмени успешно отправились в желудок!");
            transform.localScale -= new Vector3(0.4f, 0.4f, 0.4f);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("lol..."))
        {
            Debug.Log("Пельмени evyj;bkmcm");
            transform.localScale += new Vector3(0.4f, 0.4f, 0.4f);
            Destroy(collision.gameObject);
        }
    }
        
    }
