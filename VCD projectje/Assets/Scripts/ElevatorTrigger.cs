using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
    public GameObject ElevatorUI;
    public bool PlayerOnElevator;
    public GameObject PlayerCapsule;
    public GameObject UIPressE;
    public GameObject UIExitElevator;
    public GameObject UIElevatorControls;
    public GameObject ThirdPersonCam;
    private bool ElevatorActivated;
    [SerializeField] private float speed = 3.0f;

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.name == "PlayerCapsule")
        {
            ElevatorUI.SetActive(true);
            PlayerOnElevator = true;
        }
    }

    private void OnTriggerExit(Collider collisionInfo)
    {
        if (collisionInfo.name == "PlayerCapsule")
        {
            ElevatorUI.SetActive(false);
            PlayerOnElevator = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerOnElevator == true)
        {
            if (ElevatorActivated == false)
            {
                PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled = false;
                //PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed = 0;
                // PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().SprintSpeed = 0;
                //PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().JumpHeight = 0;
                ElevatorActivated = true;
                PlayerCapsule.transform.SetParent(transform);
                UIPressE.SetActive(false);
                UIExitElevator.SetActive(true);
                UIElevatorControls.SetActive(true);
                ThirdPersonCam.SetActive(true);
            }

            else
            {
                PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled = true;
                //PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed = 4;
                //PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().SprintSpeed = 6;
                //PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().JumpHeight = 1;
                ElevatorActivated = false;
                PlayerCapsule.transform.SetParent(null);
                UIPressE.SetActive(true);
                UIExitElevator.SetActive(false);
                UIElevatorControls.SetActive(false);
                ThirdPersonCam.SetActive(false);
            }
        }

            if (ElevatorActivated == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
    }


}
