using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondFloorPanel : MonoBehaviour
{
    public GameObject button;
    public Material on;
    public Material off;

    // Start is called before the first frame update
    void Start()
    {
        SecondFloor.OnComplete += lvlComplete;
    }

    void lvlComplete()
    {
        Debug.Log("lvlComplete in PaneControl");
        turnOn();
    }
    
    public void turnOn()
    {
        button.GetComponent<Renderer>().material = on;
        button.GetComponentInParent<ElevatorDoorController>().isPowered = true;
    }
    public void turnOff()
    {
        button.GetComponent<Renderer>().material = off;
        button.GetComponentInParent<ElevatorDoorController>().isPowered = false;
    }
}