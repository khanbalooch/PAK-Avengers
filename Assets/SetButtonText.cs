using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetButtonText : MonoBehaviour
{

    public Button playNextButton;
    void Start()
    {
        playNextButton.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("isDoublePlayerMode") == 1 ? "NEXT" : "PLAY";

    }

}