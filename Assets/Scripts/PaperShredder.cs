using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperShredder : MonoBehaviour
{
    public delegate void shred();
    public static event shred OnShred; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pickUp")
        {
            Destroy(other.gameObject);
            OnShred();

        }
    }
}
