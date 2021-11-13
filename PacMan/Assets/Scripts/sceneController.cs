using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    public Button resetButton;
    public Button playButton;
    public GameObject settingsPanel;
    public float RestartLevelAfterSeconds=1.5f;
    public float StartSceneAfterSeconds = 1.5f;
   
    private void Start()
    {
       
        
    }
    public void resetScene() // resetbutton will call this function to reset the scene .
    {
        
        StartCoroutine(ResetScene());
    }
   
     IEnumerator ResetScene()
    {
        yield return new WaitForSeconds(RestartLevelAfterSeconds); //restart the level after value of the "restartlevelafterseconds" variable  delay .
        SceneManager.LoadScene("Main");
        
    }
    public void startScene() 
    {
        StartCoroutine(startSceneDelay());
    }
   IEnumerator startSceneDelay()//loading scene delay
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(StartSceneAfterSeconds);
        SceneManager.LoadScene("Main");
    }
    
    public void quitGame() // function to quit application
    {
        Application.Quit();
    }

    public void gotoMainMenu() // this will take us to main menu screen
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void settingsPanelFunc() // settings function
    {
        Time.timeScale = 0;
        settingsPanel.SetActive(true);
    }
    public void closeSettings() // function to close settings
    {
        Time.timeScale = 1;
        settingsPanel.SetActive(false);
    }


}
