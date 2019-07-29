using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtogame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Winnerdata.winner);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Demo");
        }
    }
}
