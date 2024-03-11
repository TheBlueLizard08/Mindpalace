using UnityEngine;
using UnityEngine.SceneManagement;


    public class MainMenuManager : MonoBehaviour
{
    public GameObject CreditsCanvas;
    public GameObject SettingsCanvas;


    public void quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenSettings()
    {
        SettingsCanvas.SetActive(true);
    }

    public void OpenCredits()
    {
        CreditsCanvas.SetActive(true);
    }
}
