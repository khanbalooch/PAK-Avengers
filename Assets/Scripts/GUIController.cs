using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour 
{
	public Button singlePlayerButton;
	public Button doublePlayerButton;
    public Button settingButton;
    public Canvas mainCanvas;
    public Canvas settingCanvas;
    void Start()
    {
        
        singlePlayerButton.onClick.AddListener(() => 
        {

            LoadScene("PlayerViewScene");
            PlayerPrefs.SetInt("isDoublePlayerMode",0);
        });
        doublePlayerButton.onClick.AddListener(() => 
        {
            LoadScene("PlayerViewScene");
            PlayerPrefs.SetInt("isDoublePlayerMode", 1);
        });
        settingButton.onClick.AddListener(  LoadSetting );

    }
    void Update()
    {
        
        

    }
    public void LoadSetting()
    {
        
        settingCanvas.gameObject.SetActive(true);
        //mainCanvas.GetComponent<Canvas>()
        //mainCanvas.gameObject.SetActive(false);
        
    }
    public void LoadScene(string sceneName)
	{
        SceneManager.LoadScene(sceneName);
	}
	
}