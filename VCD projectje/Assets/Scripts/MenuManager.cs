using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Canvas;
    [SerializeField] GameObject PlayerCapsule;
    public GameObject CreditsCanvas;
    public GameObject SettingsCanvas;

    private void Awake()
    {
        PlayerCapsule = GameObject.FindWithTag("Player");
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        //Debug.Log(mode);
        PlayerCapsule = GameObject.FindWithTag("Player");
    }

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

        //if(CreditsCanvas != isActiveAndEnabled && SettingsCanvas != isActiveAndEnabled)
        //{
            //Debug.Log("Close Menu");
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled = true;
       // }
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
