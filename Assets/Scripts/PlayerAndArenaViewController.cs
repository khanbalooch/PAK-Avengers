using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAndArenaViewController : MonoBehaviour
{
    public Button playButton;
    public Button backButton;
    public GameObject IronMan;
    public Camera PlayerViewCamera;
    public Camera EarthViewCamera;
    void Start()
    {
        playButton.onClick.AddListener( () => 
        {

        });

        backButton.onClick.AddListener( () => 
        {
            SceneManager.LoadScene("GUI");
        });
    } 
}
