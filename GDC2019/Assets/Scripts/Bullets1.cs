using UnityEngine;
using System.Collections;

public class Bullets1 : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform Spawnpoint;
    public float Speed = 10;
    float shootingtimer = 0;
    public float BulletsPrSecond;
    public int PeacePeriod = 1;
    float Starttime;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        if (shootingtimer > BulletsPrSecond && Time.time - Starttime > PeacePeriod)
        {

            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, Spawnpoint.rotation);

            clone.velocity = Spawnpoint.TransformDirection(Vector3.up * Speed);
            shootingtimer = 0;

        }
        shootingtimer += Time.deltaTime;
    }

    void OnCollisionEnter(Collision a)
    {




        Destroy(gameObject);


    }
}