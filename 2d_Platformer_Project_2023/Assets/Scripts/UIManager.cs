using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
  
    [Header("Pause")]
    [SerializeField] private GameObject pauseScreen;

    private void Awake()
    {
       
        pauseScreen.SetActive(false);
          PauseGame(pauseScreen.activeInHierarchy);
    }
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //If pause screen already active unpause and viceversa
            PauseGame(!pauseScreen.activeInHierarchy);
            
        }
    }

 


    //Main Menu
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

   
   public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    
    public void PauseGame(bool status)
    {
        //If status == true pause | if status == false unpause
        pauseScreen.SetActive(status);

        //When pause status is true change timescale to 0 (time stops)
        //when it's false change it back to 1 (time goes by normally)
        if (status)
         {  Time.timeScale = 0;}
        else
            Time.timeScale = 1;
    }
}