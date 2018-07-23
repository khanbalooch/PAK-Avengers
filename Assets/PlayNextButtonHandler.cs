using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayNextButtonHandler : MonoBehaviour {

    public Button playNextButton;
    public Camera playerViewCamera;
    public Camera earthViewCamera;
    public Canvas playerAndArenaViewCanvas;
    public Canvas findEnemyCanvas;

     
    void Start ()
    {
        playNextButton.onClick.AddListener(() =>                   
        {
            PlayNext();                                            //add OnClick handler for Play/Next button
        });
	
	}
    public void PlayNext()
    {
        PlayerPrefs.SetString("playerCharacter","IronMan");         //set player chosen character
        PlayerPrefs.SetString("playingEnvironment","Scifi");        //set player chosen environment

        if (PlayerPrefs.GetInt("isDoublePlayerMode") == 1)          //check if it is double player mode 
        {
            playerAndArenaViewCanvas.gameObject.SetActive(false);   // disable current canvas 
            playerViewCamera.gameObject.SetActive(false);           // disable camera for current canvas
            findEnemyCanvas.gameObject.SetActive(true);             // enavle next canvas    
            earthViewCamera.gameObject.SetActive(true);             //enable camera for current canvas
        }
        else
        {
                                                                     //enter single player gameplay 
        }
        {
                                                                     
        }
    }
	// Update is called once per frame
	void Update ()
    {
	
	}
}
