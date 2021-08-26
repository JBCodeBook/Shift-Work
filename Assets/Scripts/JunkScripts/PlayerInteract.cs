
using UnityEngine;
using System.Collections;

public class PlayerInteract : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)) //Change the Controls here
            CheckDoor();
    }

    void CheckDoor()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 10f))
        {
            Debug.Log(hit.transform.tag);
            if (hit.transform.tag == "Door")
            {
                hit.transform.gameObject.GetComponentInParent<HingeScript>().OpenDoor = !hit.transform.gameObject.GetComponentInParent<HingeScript>().OpenDoor;
            }
        }
    }
}

