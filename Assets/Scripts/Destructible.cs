using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    public GameObject player;
    public float interval = 5f;
    public Vector3 scale; 

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag != "Destructable") {
            if (col.gameObject.tag == "Fist")
            {
                Debug.Log(gameObject.tag);
                if (col.gameObject.tag == "Fist")
                {
                    
                    GameObject destructObj = Instantiate(destroyedVersion, transform.position, transform.rotation);
                    Destroy(gameObject);
                    Destroy(destructObj, interval);
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
