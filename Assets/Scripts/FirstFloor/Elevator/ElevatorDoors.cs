using UnityEngine;
using System.Collections;

public class ElevatorDoors : MonoBehaviour
{

    [Header("Door Settings")]
    public float Smooth;
    public float Displace;
    public bool isLocked = false;
    public GameObject leftDoor;
    public GameObject rightDoor;

    [Header("Is the Door Open?")]
    public bool isOpen;


    public IEnumerator OpenElevator()
    {
        float elapsedTime = 0;
        float LeftToPos = leftDoor.transform.localPosition.x - Displace;
        float RightToPos = rightDoor.transform.localPosition.x + Displace;

        while (elapsedTime < Smooth)
        {
            isLocked = true;
            isOpen = true;

            elapsedTime += Time.deltaTime;

            leftDoor.transform.localPosition = Vector3.Lerp(leftDoor.transform.localPosition, new Vector3(LeftToPos, leftDoor.transform.localPosition.y, leftDoor.transform.localPosition.z), (elapsedTime  / Smooth));
            rightDoor.transform.localPosition = Vector3.Lerp(rightDoor.transform.localPosition, new Vector3(RightToPos, rightDoor.transform.localPosition.y, rightDoor.transform.localPosition.z), (elapsedTime / Smooth));

            yield return null;
            isOpen = true;
            isLocked = false;
        }
    }

    public IEnumerator CloseElevator()
    {
        float elapsedTime = 0;
        float LeftToPos = leftDoor.transform.localPosition.x + Displace;
        float RightToPos = rightDoor.transform.localPosition.x - Displace;

        while (elapsedTime < Smooth)
        {
            isLocked = true;
            isOpen = false;

            elapsedTime += Time.deltaTime;

                leftDoor.transform.localPosition = Vector3.Lerp(leftDoor.transform.localPosition, new Vector3(LeftToPos, leftDoor.transform.localPosition.y, leftDoor.transform.localPosition.z), (elapsedTime / Smooth));
                rightDoor.transform.localPosition = Vector3.Lerp(rightDoor.transform.localPosition, new Vector3(RightToPos, rightDoor.transform.localPosition.y, rightDoor.transform.localPosition.z), (elapsedTime / Smooth));
            
            yield return null;
            isOpen = false;
            isLocked = false;
        }
    }


}