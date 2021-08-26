using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPanelControl : MonoBehaviour
{
    public GameObject Elevator;
    public GameObject Floor1;
    public GameObject Floor2;
    public GameObject Floor3;
    public GameObject Floor4;
    public GameObject Floor5;
    public GameObject Floor6;
    public bool hasCoroutine;

    public void MoveUp(GameObject targetPos)
    {
        hasCoroutine = true;
        StartCoroutine(Elevator.GetComponent<MoveObject>().SmoothLerp(3f, Elevator, targetPos));
    }
}
