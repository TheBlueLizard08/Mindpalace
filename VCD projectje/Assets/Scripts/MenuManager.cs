using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Canvas;
    [SerializeField] GameObject PlayerCapsule;
    public GameObject CreditsCanvas;
    public GameObject SettingsCanvas;
    private bool MoveDisabled;

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
        CloseMenu();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Menu();
        }

    }
    public void quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void MenuScreen()
    {
            SceneManager.LoadScene("Main Menu");
    }

    public void Menu()
    {
        Canvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

        //check if movement is already disabled
        if (PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled == false)
        {
            MoveDisabled = true;
        }

        else
        {
            MoveDisabled = false; 
            PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled = false;
        }
    }

    public void CloseMenu()
    {
        Canvas.SetActive(false);

        //if(CreditsCanvas != isActiveAndEnabled && SettingsCanvas != isActiveAndEnabled)
        //{
            //Debug.Log("Close Menu");
            Cursor.lockState = CursorLockMode.Locked;

        //check if movement needs to stay disabled or not
        if (MoveDisabled == false)
        {
            PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled = true;
        }
       // }
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
