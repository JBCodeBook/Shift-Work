using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    private bool isTopFloor = false;
    private bool isBottomFloor = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Final_floor")
        {
            isTopFloor = true;
        }
        if(other.tag == "Bottom_floor")
        {
            isBottomFloor = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Final_floor")
        {
            isTopFloor = false;
        }
        if (other.tag == "Bottom_floor")
        {
            isBottomFloor = false;
        }
    }

    public bool isBottom()
    {
        return isBottomFloor;
    }
    public bool isTop()
    {
        return isTopFloor;
    }
}
