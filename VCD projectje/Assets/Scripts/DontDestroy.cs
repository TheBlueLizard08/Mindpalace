using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public GameObject permanentObject;
    void Awake()
    {
        DontDestroyOnLoad(permanentObject);
    }

        private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        //Debug.Log(mode);
        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            Destroy(permanentObject);
        }
    }
}
