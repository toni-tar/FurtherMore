using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSword2 : MonoBehaviour
{
    public GameObject swordTwo;
    private float speed = 100f;
    private Quaternion targetRotation;
    private bool isTarget = true;

    void Start()
    {
        targetRotation = Quaternion.Euler(0, 0,90f);
    }


    void Update()
    {
        //Определяем направление вращения
        Quaternion currentRotation = transform.rotation;
        if (isTarget)
        {
            // Вращаемся к цели
            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, speed * Time.deltaTime);
            if (Quaternion.Angle(currentRotation, targetRotation) < 0.1f)
            {
                isTarget = false; // Меняем направление вращения
            }
        }
        else
        {
            // Возвращаемся обратно к 0 градусам
            transform.rotation = Quaternion.RotateTowards(currentRotation, Quaternion.Euler(0, 0, 0), speed * Time.deltaTime);
            if (Quaternion.Angle(currentRotation, Quaternion.Euler(0, 0, 0)) < 0.1f)
            {
                isTarget = true; // Меняем направление вращения
            }
        }
    }
}
