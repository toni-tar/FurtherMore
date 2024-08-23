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

    }
}
