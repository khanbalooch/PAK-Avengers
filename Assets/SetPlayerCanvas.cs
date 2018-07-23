using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class SetPlayerCanvas : MonoBehaviour {

    public Text playerCharacterName;
    
	// Use this for initialization
	void Start ()
    {
	    playerCharacterName.text = PlayerPrefs.GetString("playerCharacter");        //get player character from player prefs
       
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
