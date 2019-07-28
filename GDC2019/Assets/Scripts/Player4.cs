using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : MonoBehaviour

{
    Rigidbody rb;
    public float rotationSpeed = 50f;
    public float speed = 10f;
    public GameObject GM;
    Collision cb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Makes the player go forward constantly
        rb.AddForce(transform.up * Time.deltaTime * speed, ForceMode.Force);

        //Controls rotation on the player
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, 0, Time.deltaTime * rotationSpeed, Space.Self);
        }




        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, 0, Time.deltaTime * -rotationSpeed, Space.Self);
        }
    }



    //Makes the player die to bullets and send a -1 player to GameMaster

    void OnCollisionEnter(Collision collision)
        {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Wall")
        {

                GM.GetComponent<GameMaster>().Updateplayercount();

            Destroy(gameObject);


        }
        }
    }


    



