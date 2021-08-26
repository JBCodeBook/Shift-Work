using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextFloorTrigger : MonoBehaviour
{
    public GameObject elevator;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Closing Doors");
        if (other.gameObject.tag == "Character")
        {
            StartCoroutine(elevator.GetComponent<ElevatorDoors>().CloseElevator());
        }
    }
}
