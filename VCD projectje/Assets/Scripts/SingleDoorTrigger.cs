using UnityEngine;

public class SingleDoorTrigger : MonoBehaviour
{
    public GameObject Door;

    private void OnTriggerEnter(Collider collisionInfo)
    {
        Debug.Log("collision");
        if (collisionInfo.name == "PlayerCapsule")
        {
            Door.GetComponent<Animator>().enabled = true;
            Debug.Log("animate");
        }
    }
}
