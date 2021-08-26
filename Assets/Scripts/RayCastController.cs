using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastController : MonoBehaviour
{
    public float rayRange = 4;
    string[] collidablelayers = { "NPC", "Interior Doors", "Interaction" };
    int layersToCheck; 

    private void Start()
    {
        layersToCheck = LayerMask.GetMask(collidablelayers);
    }

    void Update()
    {
        CastRay();
    }

    void CastRay()
    {
        

        RaycastHit hitInfo = new RaycastHit();

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, rayRange, layersToCheck))
        {
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, rayRange);

            if (hit)
            {
                GameObject hitObject = hitInfo.transform.gameObject;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hitObject.GetComponent<IInteractable>() != null)
                    {
                        hitObject.GetComponent<IInteractable>().interact();
                    }

                    if (hitObject.transform.tag == "Door")
                    {
                        hitObject.transform.gameObject.GetComponentInParent<HingeScript>().OpenDoor = !hitObject.transform.gameObject.GetComponentInParent<HingeScript>().OpenDoor;
                    }
                }
            }
        }
    }   
}
