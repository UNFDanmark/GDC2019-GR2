/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float Cameraspeed = 10f;
    float savedTime;


    // Start is called before the first frame update
    void Start()
    {
        savedTime = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Time.time - savedTime > 20 && Time.time - savedTime < 40)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5);
        }

        if (Time.time - savedTime > 60 && Time.time - savedTime < 75)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 7);
        }


    }

    }

    */