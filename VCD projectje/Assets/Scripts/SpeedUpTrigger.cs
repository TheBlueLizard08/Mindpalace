using UnityEngine;

public class SpeedUpTrigger : MonoBehaviour
{
    public GameObject PlayerCapsule;

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.name == "PlayerCapsule")
        {
            //PlayerCapsule.GetComponent<Animator>().enabled = true;
            PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().Accelerate = true;
        }
    }
}
