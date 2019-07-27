using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour

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
        //rb.velocity = transform.up * Time.deltaTime * speed;
        rb.AddForce(transform.up * Time.deltaTime * speed, ForceMode.Force);
        //Controls rotation on the player
        if (Input.GetKey("g"))
        {
            transform.Rotate(0, 0, Time.deltaTime * rotationSpeed, Space.Self);
        }
        if (Input.GetKey("j"))
        {
            transform.Rotate(0, 0, Time.deltaTime * -rotationSpeed, Space.Self);
        }





    }
    //Makes the player die to bullets and send a -1 player to GameMaster
    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Bullet")
            {

                GM.GetComponent<GameMaster>().Updateplayercount();

            Destroy(gameObject);


        }
        }

    
}




    


