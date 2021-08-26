using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButtonPanel : MonoBehaviour
{
    public GameObject button;
    public Material on;
    public Material off;

    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Renderer>().material = off;
        EndTrigger.OnEndTrigger += lvlComplete;
    }

    void lvlComplete()
    {
        button.GetComponent<ElevatorDoorController>().isPowered = true;
        
        button.GetComponent<Renderer>().material = on;
    }
}