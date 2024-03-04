using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject PlayerCapsule;

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
        Cursor.lockState = CursorLockMode.Locked;
        PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled = true;
    }
}
