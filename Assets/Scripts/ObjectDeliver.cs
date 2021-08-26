using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDeliver : MonoBehaviour
{
    public delegate void pop();
    public static event pop OnPop;
    private int objective;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pickUp")
        {
            Destroy(other.gameObject);
            OnPop();

        }
    }


}
