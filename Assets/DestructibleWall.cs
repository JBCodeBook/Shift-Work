using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleWall : MonoBehaviour
{
    public GameObject destroyedVersion;
    public GameObject player;
    public float interval = 5f;
    public Vector3 scale;

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Punching Wall");
        if (col.gameObject.tag != "Destructable")
        {
            if (col.gameObject.tag == "Fist")
            {
                Debug.Log(gameObject.tag);
                if (col.gameObject.tag == "Fist")
                {
                    this.GetComponentInChildren<Rigidbody>().useGravity = true;
                    this.GetComponentInChildren<Rigidbody>().mass = 10; 
                    Destroy(this, interval);
                }
            }
        }
    }

    public IEnumerator removeObject(GameObject target)
    {
        Debug.Log("In removeObject");
        Debug.Log(target);
        yield return new WaitForSeconds(2f);
        Debug.Log("DONE");

    }
}
