                                        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidsspawnerscript : MonoBehaviour
{
    public float time = 4;
    public float timeleft;
    public GameObject commet;
    public float minforward;
    public float maxforward;
    public float minsideways;
    public float maxsideways;
     
    // Start is called before the first frame update
    void Start()
    {
        timeleft = time;

    }

    // Update is called once per frame
    void Update()
    {
        timeleft = timeleft - Time.deltaTime;
        if (timeleft <= 0)
        {
            timeleft = time;
            int selector = Random.Range(0, 4);
            if (selector == 0)
            {
                float xposition = Random.Range(-40, 40);
                GameObject Createdcommet = Instantiate(commet, new Vector3(xposition, 0, 90), Quaternion.identity);
                Createdcommet.GetComponent<Meteor>().direction.z = -Random.Range(minforward, maxforward);
                Createdcommet.GetComponent<Meteor>().direction.x = Random.Range(minsideways, maxsideways);

            }
            else if (selector == 1)
            {

                float xposition = Random.Range(-40, 40);
                GameObject Createdcommet = Instantiate(commet, new Vector3(xposition, 0, -90), Quaternion.identity);
                Createdcommet.GetComponent<Meteor>().direction.z = Random.Range(minforward, maxforward);
                Createdcommet.GetComponent<Meteor>().direction.x = Random.Range(minsideways, maxsideways);
            }
            else if (selector == 2 )
            {

                float zposition = Random.Range(-70,70);
                GameObject Createdcommet = Instantiate(commet, new Vector3(70,0,zposition), Quaternion.identity);
                Createdcommet.GetComponent<Meteor>().direction.x = -Random.Range(minforward, maxforward);
                Createdcommet.GetComponent<Meteor>().direction.z = Random.Range(minsideways, maxsideways);
            
        }
            else if (selector == 3)
            {
                float zposition = Random.Range(-70, 70);
                GameObject Createdcommet = Instantiate(commet, new Vector3(-70, 0, zposition), Quaternion.identity);
                Createdcommet.GetComponent<Meteor>().direction.x = +Random.Range(minforward, maxforward);
                Createdcommet.GetComponent<Meteor>().direction.z = Random.Range(minsideways, maxsideways);
            }


        }
    }
}
