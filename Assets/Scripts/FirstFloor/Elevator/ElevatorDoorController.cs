using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorController : MonoBehaviour, IInteractable
{
    private bool isBusy = false;
    public bool isOpen = false;
    public bool isPowered = false;
    public GameObject elevator; 

    void start()
    {
        isBusy = elevator.GetComponent<ElevatorDoors>().isLocked;
    }

    public void PushButton()
    {
        isOpen = elevator.GetComponent<ElevatorDoors>().isOpen;
        Debug.Log(isOpen);

        if (!isOpen)
        {
            StartCoroutine(elevator.GetComponent<ElevatorDoors>().OpenElevator());
        }
        else if (isOpen)
        {
            StartCoroutine(elevator.GetComponent<ElevatorDoors>().CloseElevator());
        }
    }

    public void interact()
    {
        isBusy = elevator.GetComponent<ElevatorDoors>().isLocked;
        if (!isBusy && isPowered)
        {
            PushButton();
        }
    }
}
