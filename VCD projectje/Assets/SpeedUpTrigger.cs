using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpTrigger : MonoBehaviour
{
    public GameObject PlayerCapsule;

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.name == "PlayerCapsule")
        {
            PlayerCapsule.GetComponent<Animator>().enabled = true;
        }
    }
}
