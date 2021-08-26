using UnityEngine;
using System.Collections;

public class HingeScript : MonoBehaviour
{

    [Header("Door Settings")]
    public float Smooth;
    public float OpenAngle;
    public float CloseAngle;

    [Header("Is the Door Open?")]
    public bool OpenDoor;

    void Update()
    {
       
        if (OpenDoor)
        {
            Quaternion DoorOpen = Quaternion.Euler(0, OpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, DoorOpen, Time.deltaTime * Smooth);
        }

        if (!OpenDoor)
        {
            Quaternion DoorOpen = Quaternion.Euler(0, CloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, DoorOpen, Time.deltaTime * Smooth);
        }
    }
}
