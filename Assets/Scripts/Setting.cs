using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Barrier"))
        {
            Debug.Log("�������� ���������!!!!!");
            transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
        }
        if (collision.gameObject.CompareTag("Height"))
        {
            Debug.Log("�������� ������!");
            transform.localScale += new Vector3(0.4f, 0.4f, 0.4f);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Small"))
        {
            Debug.Log("�������� ������� ����������� � �������!");
            transform.localScale -= new Vector3(0.4f, 0.4f, 0.4f);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("lol..."))
        {
            Debug.Log("�������� evyj;bkmcm");
            transform.localScale += new Vector3(0.4f, 0.4f, 0.4f);
            Destroy(collision.gameObject);
        }
    }
        
    }
