using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public delegate void endTrigger();
    public static event endTrigger OnEndTrigger;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Character")
        {
            OnEndTrigger();
        }
    }
}
