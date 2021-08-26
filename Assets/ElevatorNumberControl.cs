using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorNumberControl : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public GameObject third;
    public GameObject fourth;
    public GameObject fifth;
    public GameObject sixth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TargetFirstFloor")
        {
            first.SetActive(true);
            second.SetActive(false);
            third.SetActive(false);
            fourth.SetActive(false);
            fifth.SetActive(false);
            sixth.SetActive(false);
        }

        if (other.gameObject.name == "TargetSecondFloor")
        {
            first.SetActive(false);
            second.SetActive(true);
            third.SetActive(false);
            fourth.SetActive(false);
            fifth.SetActive(false);
            sixth.SetActive(false);
        }

        if (other.gameObject.name == "TargetThirdFloor")
        {
            first.SetActive(false);
            second.SetActive(false);
            third.SetActive(true);
            fourth.SetActive(false);
            fifth.SetActive(false);
            sixth.SetActive(false);
        }

        if (other.gameObject.name == "TargetFourthFloor")
        {
            first.SetActive(false);
            second.SetActive(false);
            third.SetActive(false);
            fourth.SetActive(true);
            fifth.SetActive(false);
            sixth.SetActive(false);
        }

        if (other.gameObject.name == "TargetFifthFloor")
        {
            first.SetActive(false);
            second.SetActive(false);
            third.SetActive(false);
            fourth.SetActive(false);
            fifth.SetActive(true);
            sixth.SetActive(false);
        }

        if (other.gameObject.name == "TargetSixthFloor")
        {
            first.SetActive(false);
            second.SetActive(false);
            third.SetActive(false);
            fourth.SetActive(false);
            fifth.SetActive(false);
            sixth.SetActive(true);
        }

    }
}
