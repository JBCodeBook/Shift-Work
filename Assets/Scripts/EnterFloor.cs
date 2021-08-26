using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFloor : MonoBehaviour
{

    public delegate void FloorStart();
    public static event FloorStart OnEnter;
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<SecondFloor>().enabled = true;

        if (other.gameObject.tag == "Character")
        {
            OnEnter();
        }
    }
}