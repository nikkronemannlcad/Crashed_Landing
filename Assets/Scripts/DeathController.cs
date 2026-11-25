using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    /// <summary>
    /// This script will be on the player and control when they die!
    /// </summary>
    public PlayerHealthScript phs;
    private Scene thisScene;
    private string thisSceneName;
    [SerializeField] private GameObject loseScreen;
    private GameObject player;
    private GameObject playerCamera;

    private void Start()
    {
        thisScene = SceneManager.GetActiveScene();
        thisSceneName = thisScene.name;
        player = GameObject.FindGameObjectWithTag("Player");
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        if (phs.playerHitPoints <= 0) //when you lose
        {
            Debug.Log("playerlost");
            loseScreen.SetActive(true);
            Time.timeScale = 0.0f;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; 
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(thisSceneName);
        Time.timeScale = 1.0f;
        Destroy(player);
        Debug.Log("Retry Button Pressed");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Button Pressed");
    }
}
