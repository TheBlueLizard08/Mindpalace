using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.name == "PlayerCapsule")
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
