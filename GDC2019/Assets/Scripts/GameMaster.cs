using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public float startofgame;
    public float Cameraspeed = 10f;
    public AudioSource audioData;
    public AudioClip saudioData;
    public int Playercount = 4;
    public static bool ReadySound = true;
 
    // Start is called before the first frame update
    void Start()
    {
        startofgame = Time.time;
    }

    /*void FixedUpdate()
    {
        
        if (ReadySound = true && Playercount == 3)
        {
            audioData.PlayOneShot(saudioData);
            ReadySound = false;
        }
        if (ReadySound = true && Playercount == 2)
        {
            audioData.PlayOneShot(saudioData);
            ReadySound = false;
        }
        if (ReadySound = true && Playercount == 1)
        {
            audioData.PlayOneShot(saudioData);
            ReadySound = false;
        }

    }
    */
    // Update is called once per frame
    public void Updateplayercount(string playername)
    {


        Setplayercountanddeth(playername);
        Playercount = Playercount - 1;

        if (Playercount == 1)
        {
            Winnerdata.winner = playername;
            print(playername);
            SceneManager.LoadScene("Winscreen");
            print("spiller 1 drab: " + Winnerdata.klllsbyplayer1);
            print("spiller 2 drab: " + Winnerdata.klllsbyplayer2);
            print("spiller 3 drab: " + Winnerdata.klllsbyplayer3);
            print("spiller 4 drab: " + Winnerdata.klllsbyplayer4);
        }




    }
    void Setplayercountanddeth(string playername)
    {
         if (playername == "player1")
        {
            Winnerdata.player1place = Playercount;
            Winnerdata.dethtimeplayer1 = Time.time - startofgame;
        }
        if (playername == "player2")
        {
            Winnerdata.player2place = Playercount;
            Winnerdata.dethtimeplayer2 = Time.time - startofgame;
        }
        if (playername == "player3")
        {
            Winnerdata.player3place = Playercount;
            Winnerdata.dethtimeplayer3 = Time.time - startofgame;
        }
        if (playername == "player4")
        {
            Winnerdata.player4place = Playercount;
            Winnerdata.dethtimeplayer4 = Time.time - startofgame;

        }
    }

}
