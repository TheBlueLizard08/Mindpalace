using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject LeftDoor;
    public GameObject RightDoor;
    public GameObject Timeline;

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if(collisionInfo.name == "PlayerCapsule")
        {
            //LeftDoor.GetComponent<Animator>().enabled = true;
            //RightDoor.GetComponent<Animator>().enabled = true;
            Timeline.SetActive(true);
        }
    }
}
