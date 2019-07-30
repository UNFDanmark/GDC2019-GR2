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
        Statestikforplayer1.GetComponent<Text>().text = Winnerdata.player1place+"\n"+Winnerdata.dethtimeplayer1.ToString("F2")+" "+"sec.";
        Statestikforplayer2.GetComponent<Text>().text = Winnerdata.player2place + "\n" + Winnerdata.dethtimeplayer2.ToString("F2")+" " + "sec.";
        Statestikforplayer3.GetComponent<Text>().text = Winnerdata.player3place + "\n" + Winnerdata.dethtimeplayer3.ToString("F2")+" " + "sec.";
        Statestikforplayer4.GetComponent<Text>().text = Winnerdata.player4place + "\n" + Winnerdata.dethtimeplayer4.ToString("F2")+" " + "sec.";

        float winnertime = Winnerdata.dethtimeplayer1;
        if (Winnerdata.dethtimeplayer2 > winnertime)
        {
            winnertime = Winnerdata.dethtimeplayer2;
        }
        if (Winnerdata.dethtimeplayer3 > winnertime)
        {
            winnertime = Winnerdata.dethtimeplayer3;
        }
        if (Winnerdata.dethtimeplayer4 > winnertime)
        {
            winnertime = Winnerdata.dethtimeplayer4;
        }

        if (Winnerdata.player1place == 0)
        {
            Statestikforplayer1.GetComponent<Text>().text = "Win\n" + winnertime.ToString("F2") + " sec.";
        }
        if (Winnerdata.player2place == 0)
        {
            Statestikforplayer2.GetComponent<Text>().text = "Win\n" + winnertime.ToString("F2") + " sec.";
        }
        if (Winnerdata.player3place == 0)
        {
            Statestikforplayer3.GetComponent<Text>().text = "Win\n" + winnertime.ToString("F2") + " sec.";
        }
        if (Winnerdata.player4place == 0)
        {
            Statestikforplayer4.GetComponent<Text>().text = "Win\n" + winnertime.ToString("F2") + " sec.";
        }
        Winnerdata.player1place = 0;
        Winnerdata.player2place = 0;
        Winnerdata.player3place = 0;
        Winnerdata.player4place = 0;

        Winnerdata.dethtimeplayer1 = 0;
        Winnerdata.dethtimeplayer2 = 0;
        Winnerdata.dethtimeplayer3 = 0;
        Winnerdata.dethtimeplayer4 = 0;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
