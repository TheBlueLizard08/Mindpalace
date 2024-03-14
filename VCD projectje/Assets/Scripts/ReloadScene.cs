using UnityEngine;
using UnityEngine.SceneManagement;


public class ReloadScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider collisionInfo)
    {
        Debug.Log("collision");
        if (collisionInfo.name == "PlayerCapsule")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
