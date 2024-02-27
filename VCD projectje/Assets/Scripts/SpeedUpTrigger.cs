using UnityEngine;

public class SpeedUpTrigger : MonoBehaviour
{
    public GameObject PlayerCapsule;
    public GameObject LeftWall;
    public GameObject RightWall;

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.name == "PlayerCapsule")
        {
            //PlayerCapsule.GetComponent<Animator>().enabled = true;
            PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().Accelerate = true;
            LeftWall.GetComponent<Animator>().enabled = true;
            RightWall.GetComponent<Animator>().enabled = true;
        }
    }
}
