using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
    public GameObject ElevatorUI;
    public bool PlayerOnElevator;
    public GameObject PlayerCapsule;
    public GameObject UIPressE;
    public GameObject UIExitElevator;
    public GameObject UIElevatorControls;
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
                ElevatorActivated = true;
                PlayerCapsule.transform.SetParent(transform);
                UIPressE.SetActive(false);
                UIExitElevator.SetActive(true);
                UIElevatorControls.SetActive(true);
            }

            else
            {
                PlayerCapsule.GetComponent<StarterAssets.FirstPersonController>().enabled = true;
                ElevatorActivated = false;
                PlayerCapsule.transform.SetParent(null);
                UIPressE.SetActive(true);
                UIExitElevator.SetActive(false);
                UIElevatorControls.SetActive(false);
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
