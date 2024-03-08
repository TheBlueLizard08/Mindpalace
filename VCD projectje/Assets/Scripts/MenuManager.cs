using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject PlayerCapsule;
    public GameObject CreditsCanvas;
    public GameObject SettingsCanvas;

    private void Start()
    {
        CloseMainMenu();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu();
        }
    }
    public void quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Cursor.lockState = CursorLockMode.None;
    }

    public void MainMenu()
    {
        Canvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled = false;
    }

    public void CloseMainMenu()
    {
        Canvas.SetActive(false);

        if(CreditsCanvas != isActiveAndEnabled && SettingsCanvas != isActiveAndEnabled)
        {
            Debug.Log("Menu still open");
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled = true;
        }
    }
}
