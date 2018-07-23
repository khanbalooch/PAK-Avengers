using UnityEngine;
using UnityEngine.Networking.Types;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using System.Collections;
using System.Collections.Generic;

public class NetworkCtrl : NetworkManager
{

    //public NetworkManager networkManager;

    public void Start()
    {
        //PlayerPrefs.SetString("CloudNetworkingId","");
        //networkManager.matchMaker.SetProgramAppID((AppID));
        StartMatchMaker();
        
        
        
    }
    public void createMatch()
    {
        matchMaker.CreateMatch("ALLAH-U-AKBAR", 2, true, "", "", "", 0, 0, OnMatchCreate);
       
    }
    public void findMatch()
    {
        matchMaker.ListMatches(0, 20, "**", true, 0, 0, OnMatchList);
    }
    public void joinMatch(NetworkID netId)
    {

        matchMaker.JoinMatch(netId, "", "", "", 0, 0, OnMatchJoined);
    }
    public override void OnMatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matchList)
    {
        base.OnMatchList(success, extendedInfo, matchList);
        Debug.Log(matches.Count +" matches retrieved" + matches.Count);


        if (matches.Count != 0)
        {   // some  one already created a match so join that match
            joinMatch(matches[0].networkId);
        }else
        {
            // no match exists so create a match and wait for someone to join
            createMatch();

        }
    }
    public override void OnMatchJoined(bool success, string extendedInfo, MatchInfo matchInfo)
    {
        base.OnMatchJoined(success, extendedInfo, matchInfo);
        Debug.Log( "match joined");
    }
    public override void OnMatchCreate(bool success, string extendedInfo, MatchInfo matchInfo)
    {
        base.OnMatchCreate(success, extendedInfo, matchInfo);
        Debug.Log("new match created");
    }
    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
        Debug.Log("New Client Connected");
    }
    public override void OnServerConnect(NetworkConnection conn)
    {
        base.OnServerConnect(conn);
        Debug.Log("Connedted to server");
    }    

}
