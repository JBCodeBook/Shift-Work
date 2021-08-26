using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCamera : MonoBehaviour
{

    public GameObject cam;
    public void turnOff()
    {
        cam.SetActive(false); 
    }
}
