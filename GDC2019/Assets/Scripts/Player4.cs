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
    public float Health = 2;
    public Material FlashMaterial;
    public float time = 0.5f;
    public float timeleft;
    bool Flipper;
    Renderer rd;
    public Material StandardMaterial;
    int FlashAmount;
    public int Flashes = 6;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rd = GetComponent<Renderer>();
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




        if (Health == 1)
        {
            timeleft = timeleft - Time.deltaTime;
            if (timeleft <= 0 && FlashAmount < 6)
            {
                Flipper = !Flipper;
                timeleft = time;


                if (Flipper == true)
                {
                    rd.material = StandardMaterial;
                    FlashAmount = FlashAmount + 1;
                }
                if (Flipper == false)
                {
                    rd.material = FlashMaterial;
                }
            }
        }
    }


    //Makes the player die to bullets and send a -1 player to GameMaster

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Wall")
        {

            if (Health == 1)
            {
                if (collision.gameObject.name == "Bullet1 (Clone)")
                {
                    Winnerdata.klllsbyplayer1 = 1+Winnerdata.klllsbyplayer1;
                }
                if (collision.gameObject.name == "Bullet2 (Clone)")
                {
                    Winnerdata.klllsbyplayer2 = 1 + Winnerdata.klllsbyplayer2;
                }
                if (collision.gameObject.name == "Bullet3 (Clone)")
                {
                    Winnerdata.klllsbyplayer3 = 1 + Winnerdata.klllsbyplayer3;
                }
                if (collision.gameObject.name == "Bullet4 (Clone)")
                {
                    Winnerdata.klllsbyplayer4 = Winnerdata.klllsbyplayer4;
                }
                Destroy(gameObject);
                GM.GetComponent<GameMaster>().Updateplayercount("player4");
            }

            Health = Health - 1;

        }


    }
}





