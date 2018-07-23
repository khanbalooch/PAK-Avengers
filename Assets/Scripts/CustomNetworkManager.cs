using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.Networking.Types;
using UnityEngine.Networking.Match;
using System.Collections.Generic;

public class CustomNetworkManager : NetworkManager {

    public NetworkManager manager;
    void Start()
    {
        manager.GetComponent<NetworkManager>();
       
        manager.matchMaker.enabled = true;

    }

    public void findOpponent()
    {
        if ( manager.matches.Count == 0 )
        {
            createMatch();
        }
        else
        {
            manager.OnMatchList(true, "", new List<MatchInfoSnapshot>());//.StartCoroutine();
        }
    }
    public void createMatch()
    {
        manager.StartMatchMaker();
        manager.matchMaker.CreateMatch("ALLAH-U-AKBAR", 2, true, "", "", "", 0, 0, manager.OnMatchCreate);
    }
    public void findMatch()
    {
        manager.matchMaker.ListMatches(0, 20, "**", true, 0, 0, manager. OnMatchList);
    }
    public void joinMatch(NetworkID netId)
    {

        manager.matchMaker.JoinMatch(netId, "", "", "", 0, 0,manager. OnMatchJoined);
    }

    

}
