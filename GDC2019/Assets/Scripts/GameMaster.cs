using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public int Playercount = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Updateplayercount()
    {
        Playercount = Playercount - 1;

        if (Playercount == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
