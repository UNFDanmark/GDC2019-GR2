using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Vector3 direction= new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        //direction.z = -Random.Range(2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = direction;
        
    }
}
