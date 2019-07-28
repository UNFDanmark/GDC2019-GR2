using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour

{
    Rigidbody rb;
    public float rotationSpeed = 50f;
    public float speed = 10f;
    public GameObject GM;
    Collision cb;
    public float bouncespeed = 10f;

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
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0, Time.deltaTime * rotationSpeed, Space.Self);
        }



        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, Time.deltaTime * -rotationSpeed, Space.Self);
        }





    }
    //Makes the players bounce off each other
        void OnCollisionEnter(Collision collision)
        {

       /* if (collision.gameObject.tag == "player")
            rb.AddForce(transform.up * bouncespeed, ForceMode.Force);
            */
       //Makes the player die to bullets and send a -1 player to GameMaster

               if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Wall")
            {

                GM.GetComponent<GameMaster>().Updateplayercount();

            Destroy(gameObject);


        }
        }
    

}

