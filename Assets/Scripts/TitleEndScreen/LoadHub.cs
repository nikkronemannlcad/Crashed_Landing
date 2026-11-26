using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHub : MonoBehaviour
{
   public void LoadFirstLevel()
    {
        SceneManager.LoadScene("LEVEL_1_HUB_TEST");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
