using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{

    [SerializeField]
    float speed;

    [SerializeField]
    float leftTarget, rightTarget;


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(h * Time.deltaTime * speed * Vector2.right);



        Vector2 temp = transform.position;
        temp.x = Mathf.Clamp(temp.x, leftTarget, rightTarget);
        transform.position = temp;



    }
}

