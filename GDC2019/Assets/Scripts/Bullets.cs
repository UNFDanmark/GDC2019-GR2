using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform Spawnpoint;
    public float Speed = 1;
    float shootingtimer = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      

        if (shootingtimer > 0.3f)
        {

            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, Spawnpoint.rotation);

            clone.velocity = Spawnpoint.TransformDirection(Vector3.up * Speed);
            shootingtimer = 0;
           
        }
        shootingtimer += Time.deltaTime;
    }
}