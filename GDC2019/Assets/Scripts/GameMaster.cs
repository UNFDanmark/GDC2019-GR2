using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public float startofgame;
    public float Cameraspeed = 10f;

    public int Playercount = 4;
 
    // Start is called before the first frame update
    void Start()
    {
        startofgame = Time.time;
    }

    // Update is called once per frame
    public void Updateplayercount(string playername)
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
}
