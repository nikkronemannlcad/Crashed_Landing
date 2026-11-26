using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    /// <summary>
    /// This script is for managing which scenes will be loaded depending on what the player does.
    /// Each level needs a way to return to the hub world, which will then need to lead to the next level
    /// </summary>
    
    public List <string> sceneNames;
    
    //public ship parts collected manager
    public int shipPartsCollected = 0;


    public static GameManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Time.timeScale = 1f;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this);
    }

    //seperating each level into its own function to call for now...may keep depending on long run use
    //it'll just be easier to have a way to call the functions directly once we hammer out when the player moves on
    public void LoadMenu()
    {
       Time.timeScale = 1;
       SceneManager.LoadScene(sceneNames[0]); 
       shipPartsCollected = 0;
    }

    public void LoadHubWorld()
    {
       Time.timeScale = 1;
       SceneManager.LoadScene(sceneNames[1]); 
       Debug.Log("hub loaded");
    }

    public void LoadLevel1()
    {
       Time.timeScale = 1;
       SceneManager.LoadScene(sceneNames[2]);  
       
    }

    public void LoadEndScreen()
    {
       Time.timeScale = 1;
       SceneManager.LoadScene(sceneNames[3]);  
       
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
