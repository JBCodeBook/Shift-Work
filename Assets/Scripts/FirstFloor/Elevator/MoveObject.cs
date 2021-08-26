using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public bool isLocked = false;
    public GameObject elevator;
    public GameObject player;
    public AudioSource bkMusic;
    public AudioSource muzak;

    public IEnumerator SmoothLerp(float time, GameObject startPos, GameObject endPos)
    {
        bkMusic.Stop();
        muzak.Play();

        player.transform.parent = elevator.transform;
        Vector3 startingPos = startPos.transform.position;
        Vector3 finalPos = endPos.transform.position;


        float elapsedTime = 0;
        StartCoroutine(elevator.GetComponent<ElevatorDoors>().CloseElevator());

        while (elapsedTime < time)
        {
            
            
            isLocked = true;

            elapsedTime += Time.deltaTime;
            transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));

            yield return null;

        }
        isLocked = false;
        bkMusic.Play();
        muzak.Stop();
        player.transform.parent = null;
        StartCoroutine(elevator.GetComponent<ElevatorDoors>().OpenElevator());
    }

    public bool isButtonLocked()
    {
        return isLocked;
    }
}