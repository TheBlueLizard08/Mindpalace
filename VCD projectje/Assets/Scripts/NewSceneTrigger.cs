using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.name == "PlayerCapsule")
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
