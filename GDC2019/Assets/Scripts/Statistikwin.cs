using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistikwin : MonoBehaviour
{
    //public GameObject Statestik;
    public GameObject Statestikforplayer1;
    public GameObject Statestikforplayer2;
    public GameObject Statestikforplayer3;
    public GameObject Statestikforplayer4;
    // Start is called before the first frame update
    void Start()
    {
        //Statestik.GetComponent<Text>().text = Winnerdata.winner;
        Statestikforplayer1.GetComponent<Text>().text = "player1\n"+Winnerdata.player1place+"\n"+Winnerdata.dethtimeplayer1;
        Statestikforplayer2.GetComponent<Text>().text = "player2\n" + Winnerdata.player2place + "\n" + Winnerdata.dethtimeplayer2;
        Statestikforplayer3.GetComponent<Text>().text = "player3\n" + Winnerdata.player3place + "\n" + Winnerdata.dethtimeplayer3;
        Statestikforplayer4.GetComponent<Text>().text = "player4\n" + Winnerdata.player4place + "\n" + Winnerdata.dethtimeplayer4;

        if (Winnerdata.player1place == 0)
        {
            Statestikforplayer1.GetComponent<Text>().text = "player1\nWin";
        }
        if (Winnerdata.player2place == 0)
        {
            Statestikforplayer2.GetComponent<Text>().text = "player2\nWin";
        }
        if (Winnerdata.player3place == 0)
        {
            Statestikforplayer3.GetComponent<Text>().text = "player3\nWin";
        }
        if (Winnerdata.player4place == 0)
        {
            Statestikforplayer4.GetComponent<Text>().text = "player4\nWin";
        }
        Winnerdata.player1place = 0;
        Winnerdata.player2place = 0;
        Winnerdata.player3place = 0;
        Winnerdata.player4place = 0;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
