using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            Debug.Log("In trigger area");
            GameEvents.current.DoorWayTriggerEnter();
        }
    }
}
