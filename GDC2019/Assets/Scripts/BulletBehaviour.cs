using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision a)
    {
        if (a.gameObject.tag == "Wall" || a.gameObject.tag == "Player" || a.gameObject.tag == "Bullet" || a.gameObject.tag == " Asteroid")
        {



            Destroy(gameObject);
        }

    }
}
